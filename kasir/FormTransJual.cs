using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Xml.Linq;

namespace kasir
{
    public partial class FormTransJual : Form
    {
        BindingSource bindingSource = new BindingSource();
        public static List<Penjualan> penjualan = new List<Penjualan>();
        public static List<DetailJual> detailJual = new List<DetailJual>();
        List<string> dataBarang = new List<string>();   //tampung data barang disini
        FormLogin frmLogin = new FormLogin();
        bool dataBarangAda = false;     //pengecekan untuk btn insert, memastikan barang yg di insert ada dalam dataBarang
        int jumlahItem = 0;
        int totalBelanja = 0;
        bool isNeedSaved = false;       //true jika ada data yg diinsert tapi belum disave di list penjualan
        public FormTransJual()
        {
            InitializeComponent();
        }

        void kondisiAwal()
        {
            lblNamaBarang.Text = "";
            lblHarga.Text = "";
            lblKembali.Text = "";
            lblTotal.Text = "";
            lblItem.Text = "";
            lblStok.Text = "";
            tbKodeBarang.Text = "";
            tbJumlahBeli.Text = "";
            tbDiBayar.Text = "";
            jumlahItem = 0;
            totalBelanja = 0;
            dataBarangAda = false;
            isNeedSaved = false;
            lblTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
            lblKasir.Text = FormLogin.NamaKasir;
            //get noJual
            string noJual = "";
            if(penjualan.Count == 0)
            {
                noJual = "NJ1";

            }
            else
            {
                var last = penjualan.Last();
                noJual = last.NoJual;
                string no = noJual.Substring(2);
                int nomer = int.Parse(no) + 1;
                noJual = "NJ" + nomer.ToString();
            }

            lblNoJual.Text = noJual;
            munculDetailJual();
        }

        void getDataBarang()
        {
            if(FormMasterBarang.daftarBarang.Count > 0)
            {
                foreach(var barang in FormMasterBarang.daftarBarang)
                {
                    dataBarang.Add($"{barang.KodeBarang}-{barang.NamaBarang}");       //simpan kedalam list
                    listBarang.Items.Add($"{barang.KodeBarang}-{barang.NamaBarang}"); //
                }
            }
        }

        void getDetailBarang()
        {
            var cariBarang = FormMasterBarang.daftarBarang.Where(brg => brg.KodeBarang.Contains(tbKodeBarang.Text)).ToList();
            if (cariBarang.Count == 0)
            {
                dataBarangAda = false;
            }
            else
            {
                dataBarangAda = true;
                lblNamaBarang.Text = cariBarang[0].NamaBarang;
                lblHarga.Text = cariBarang[0].HargaJual;
                lblStok.Text = cariBarang[0].JumlahBarang;
            }
        }

        void resetValueBarang()
        {
            tbKodeBarang.Text = "";
            lblNamaBarang.Text = "";
            lblHarga.Text = "";
            lblStok.Text = "";
            tbJumlahBeli.Text = "";
        }

        void munculDetailJual()
        {
            var dtlJual = detailJual.Where(dtl => dtl.NoJual.Contains(lblNoJual.Text)).ToList();
            bindingSource.DataSource = dtlJual;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void FormTransJual_Load(object sender, EventArgs e)
        {
            kondisiAwal();
            getDataBarang();
        }

        //show listbox berisi data barang ketika focus ada di textbox KODE
        private void textBox1_Enter(object sender, EventArgs e)
        {
            listBarang.Visible = true;
        }

        //hide listbox 
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!listBarang.Focus())
            {
                listBarang.Visible = false;
            }
        }

        //filter data barang by textbox KODE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = tbKodeBarang.Text.ToLower();
            listBarang.Items.Clear();

            foreach (string item in dataBarang)
            {
                if (item.ToLower().Contains(filter))
                {
                    listBarang.Items.Add(item);
                }
            }
        }

        //autofill textbox KODE ketika memilih item di listBarang
        private void listBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBarang.SelectedItem == null)
            {

            }
            else
            {
                tbKodeBarang.Text = listBarang.SelectedItem.ToString().Split('-')[0];
                getDetailBarang();
            }
            listBarang.Visible = false;
        }

        //reset jika click listbox yg kosong
        private void listBarang_Click(object sender, EventArgs e)
        {
            if (listBarang.Items.Count == 0)
            {
                listBarang.Visible = false;
                resetValueBarang();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                getDetailBarang();
            }
        }

        //memastikan barang yg dibeli tidak melebihi stok
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int stok = lblStok.Text == "" ? 0 : int.Parse(lblStok.Text);
            int jumlah = tbJumlahBeli.Text == "" ? 0 : int.Parse(tbJumlahBeli.Text);
            if (jumlah > stok)
            {
                MessageBox.Show("Stok tidak mencukupi!");
                tbJumlahBeli.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        //insert item ke datalist detailjual
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dataBarangAda && tbJumlahBeli.Text != "")
            {
                int subtotal = int.Parse(tbJumlahBeli.Text) * int.Parse(lblHarga.Text);
                DetailJual detail = new DetailJual
                {
                    NoJual = lblNoJual.Text,
                    KodeBarang = tbKodeBarang.Text,
                    NamaBarang = lblNamaBarang.Text,
                    HargaBarang = int.Parse(lblHarga.Text),
                    JumlahJual = int.Parse(tbJumlahBeli.Text),
                    SubTotal = subtotal
                };
                detailJual.Add(detail);
                jumlahItem++;
                totalBelanja += subtotal;
                lblItem.Text = jumlahItem.ToString();
                lblTotal.Text = totalBelanja.ToString();
                dataBarangAda = false;
                isNeedSaved = true;
                resetValueBarang();
                munculDetailJual();
                bindingSource.ResetBindings(false); //refresh datagridview
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong!");
            }
        }

        //autofill label kembalian
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int bayar = tbDiBayar.Text == "" ? 0 : int.Parse(tbDiBayar.Text);
            int total = bayar - totalBelanja;
            lblKembali.Text = total.ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        //save data pembelian 
        private void button2_Click(object sender, EventArgs e)
        {
            int kembali = lblKembali.Text == "" ? -1 : int.Parse(lblKembali.Text);
            if (jumlahItem > 0 && kembali >= 0)
            {
                //insert ke datalist penjualan
                Penjualan pnjualan = new Penjualan
                {
                    NoJual = lblNoJual.Text,
                    TglJual = DateTime.Now,
                    ItemJual = jumlahItem,
                    TotalJual = totalBelanja,
                    diBayar = int.Parse(tbDiBayar.Text),
                    Kembali = kembali,
                    KodeKasir = FormLogin.KodeKasir
                };
                penjualan.Add(pnjualan);
                //kurangi stok barang
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // avoid the empty new row at the bottom
                    {
                        string kode = row.Cells[1].Value?.ToString();
                        int stokDibeli = int.Parse(row.Cells[4].Value?.ToString());
                        int stok = 0;

                        var barang = FormMasterBarang.daftarBarang.Select((value, index) => new { Value = value, Index = index }).Where(x => x.Value.KodeBarang.Contains(kode)).ToList();
                        stok = int.Parse(barang[0].Value.JumlahBarang);
                        int readyStok = stok - stokDibeli;

                        FormMasterBarang.daftarBarang[barang[0].Index].JumlahBarang = readyStok.ToString();
                    }
                }
                generateStrukPembelian();
                MessageBox.Show("Data berhasil disimpan!");
                kondisiAwal();
                lblKembali.Text = "";
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong!");
            }
        }

        //warning ketika close menu tapi belum save data pembelian
        private void FormTransJual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isNeedSaved)
            {
                DialogResult result = MessageBox.Show(
                "Data belum disimpan! Anda yakin ingin keluar?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the close
                }
                else{
                    //hapus item
                    detailJual.RemoveAt(detailJual.Count - 1);
                }
            }
        }

        void generateStrukPembelian()
        {
            // Membuka dialog untuk menyimpan file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt"; // Hanya format .txt
            saveFileDialog.Title = "Struk Pembelian"; // Judul dialog
            saveFileDialog.FileName = $"Transaksi {DateTime.Now.ToString("dd-MM-yyyy HH_mm_ss")}";

            // Jika user memilih lokasi dan menekan Save
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Menulis file teks pada lokasi yang dipilih
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Menulis informasi buku ke dalam file
                    writer.WriteLine("TOKO MAJU JAYA");
                    writer.WriteLine("Jl. Contoh No.123, Jakarta");
                    writer.WriteLine($"Tanggal : {DateTime.Now:dd/MM/yyyy HH:mm}  | Kasir: {FormLogin.NamaKasir}");
                    writer.WriteLine();
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("Nama Barang       Qty   Harga    Total");
                    writer.WriteLine("----------------------------------------");
                    foreach (var item in detailJual)
                    {
                        writer.WriteLine($"{item.NamaBarang.PadRight(18)}{item.JumlahJual.ToString().PadRight(3)} {item.HargaBarang.ToString("N0").PadLeft(8)}   {item.SubTotal.ToString("N0")}");
                    }
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine($"TOTAL".PadRight(27) + $" Rp {totalBelanja:N0}");
                    writer.WriteLine($"Dibayar".PadRight(27) + $" Rp {int.Parse(tbDiBayar.Text):N0}");
                    writer.WriteLine($"Kembali".PadRight(27) + $" Rp {int.Parse(lblKembali.Text):N0}");
                    writer.WriteLine();
                    writer.WriteLine("Terima kasih telah berbelanja!");
                }
            }
        }
    }
}
