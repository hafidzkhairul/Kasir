using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir
{
    public partial class FormMasterBarang : Form
    {
        public static List<Barang> daftarBarang = new List<Barang>();
        BindingSource bindingSource = new BindingSource();
        string KodeTemp;    //menampung value kode barang sebelum diedit
        int index;      //index buat edit datalist daftarBarang
        private Button btnSearch;

        public static void barangStarted()
        {
            daftarBarang = new List<Barang>
            {
                new Barang
                {
                    KodeBarang = "BRG001",
                    NamaBarang = "Kopi",
                    HargaBeli = "2500",
                    HargaJual = "3000",
                    JumlahBarang = "23",
                    SatuanBarang = "PCS"
                },
                new Barang
                {
                    KodeBarang = "BRG002",
                    NamaBarang = "Teh",
                    HargaBeli = "2000",
                    HargaJual = "2500",
                    JumlahBarang = "20",
                    SatuanBarang = "PCS"
                },
                new Barang
                {
                    KodeBarang = "BRG003",
                    NamaBarang = "Susu",
                    HargaBeli = "4000",
                    HargaJual = "5000",
                    JumlahBarang = "30",
                    SatuanBarang = "PCS"
                }
            };
        }
        void munculSatuan()
        {
            tbSatuan.Items.Add("PCS");
            tbSatuan.Items.Add("BOX");
            tbSatuan.Items.Add("BOTOL");
            tbSatuan.Items.Add("PAX");
            tbSatuan.Items.Add("KILO");
            tbSatuan.Items.Add("KARUNG");
        }

        void kondisiAwal()
        {
            tbKodeBarang.Text = "";
            tbNamaBarang.Text = "";
            tbHargaBeli.Text = "";
            tbHargaJual.Text = "";
            tbJumlah.Text = "";
            tbSatuan.Text = "";
        }

        void munculDataBarang()
        {
            bindingSource.DataSource = daftarBarang;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbKodeBarang = new TextBox();
            tbNamaBarang = new TextBox();
            tbHargaBeli = new TextBox();
            tbHargaJual = new TextBox();
            tbJumlah = new TextBox();
            tbSatuan = new ComboBox();
            groupBox1 = new GroupBox();
            btnTutup = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnInput = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 105);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 2;
            label3.Text = "Harga Beli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 145);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 3;
            label4.Text = "Harga Jual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 179);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 213);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 5;
            label6.Text = "Satuan Barang";
            // 
            // tbKodeBarang
            // 
            tbKodeBarang.Location = new Point(167, 34);
            tbKodeBarang.Name = "tbKodeBarang";
            tbKodeBarang.Size = new Size(166, 28);
            tbKodeBarang.TabIndex = 6;
            tbKodeBarang.KeyPress += textBox1_KeyPress;
            // 
            // tbNamaBarang
            // 
            tbNamaBarang.Location = new Point(167, 68);
            tbNamaBarang.Name = "tbNamaBarang";
            tbNamaBarang.Size = new Size(416, 28);
            tbNamaBarang.TabIndex = 7;
            // 
            // tbHargaBeli
            // 
            tbHargaBeli.Location = new Point(167, 102);
            tbHargaBeli.Name = "tbHargaBeli";
            tbHargaBeli.Size = new Size(166, 28);
            tbHargaBeli.TabIndex = 8;
            tbHargaBeli.KeyPress += tbHargaBeli_KeyPress;
            // 
            // tbHargaJual
            // 
            tbHargaJual.Location = new Point(167, 142);
            tbHargaJual.Name = "tbHargaJual";
            tbHargaJual.Size = new Size(166, 28);
            tbHargaJual.TabIndex = 9;
            tbHargaJual.KeyPress += tbHargaJual_KeyPress;
            // 
            // tbJumlah
            // 
            tbJumlah.Location = new Point(167, 176);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(166, 28);
            tbJumlah.TabIndex = 10;
            tbJumlah.KeyPress += tbJumlah_KeyPress;
            // 
            // tbSatuan
            // 
            tbSatuan.FormattingEnabled = true;
            tbSatuan.Location = new Point(167, 213);
            tbSatuan.Name = "tbSatuan";
            tbSatuan.Size = new Size(166, 30);
            tbSatuan.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnInput);
            groupBox1.Location = new Point(32, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 73);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proses";
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(331, 22);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(99, 45);
            btnTutup.TabIndex = 3;
            btnTutup.Text = "TUTUP";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(229, 22);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(96, 45);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(124, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 45);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInput
            // 
            btnInput.Location = new Point(10, 22);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(106, 45);
            btnInput.TabIndex = 0;
            btnInput.Text = "INPUT";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(589, 199);
            dataGridView1.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(375, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 28);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormMasterBarang
            // 
            BackColor = Color.DarkCyan;
            ClientSize = new Size(654, 541);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(tbSatuan);
            Controls.Add(tbJumlah);
            Controls.Add(tbHargaJual);
            Controls.Add(tbHargaBeli);
            Controls.Add(tbNamaBarang);
            Controls.Add(tbKodeBarang);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMasterBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Master Barang";
            Load += FormMasterBarang_Load;
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox tbKodeBarang;
        private TextBox tbNamaBarang;
        private TextBox tbHargaBeli;
        private TextBox tbHargaJual;
        private TextBox tbJumlah;
        private ComboBox tbSatuan;
        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnInput;
        private DataGridView dataGridView1;
        private Label label5;

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            kondisiAwal();
            munculSatuan();
            munculDataBarang();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //cek semua inputan
            if (tbKodeBarang.Text.Trim() == "" || tbNamaBarang.Text.Trim() == "" || tbHargaBeli.Text.Trim() == "" || tbHargaJual.Text.Trim() == "" || tbJumlah.Text.Trim() == "" || tbSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //cek kode barang tidak boleh sama(unique)
                var cariBarang = daftarBarang.Where(brg => brg.KodeBarang.Contains(tbKodeBarang.Text)).ToList();
                if (cariBarang.Count > 0)
                {
                    MessageBox.Show("Kode barang tidak boleh sama!");
                    tbKodeBarang.Text = "";
                }
                else
                {
                    //input ke datalist
                    Barang barang = new Barang
                    {
                        KodeBarang = tbKodeBarang.Text,
                        NamaBarang = tbNamaBarang.Text,
                        HargaBeli = tbHargaBeli.Text,
                        HargaJual = tbHargaJual.Text,
                        JumlahBarang = tbJumlah.Text,
                        SatuanBarang = tbSatuan.Text
                    };
                    daftarBarang.Add(barang);
                    MessageBox.Show("data berhasil di input");
                    bindingSource.ResetBindings(false); //refresh datagridview
                    kondisiAwal();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //cek inputan
            if (tbKodeBarang.Text.Trim() == "" || tbNamaBarang.Text.Trim() == "" || tbHargaBeli.Text.Trim() == "" || tbHargaJual.Text.Trim() == "" || tbJumlah.Text.Trim() == "" || tbSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //cek kode barang
                var cariBarang = daftarBarang.Where(brg => brg.KodeBarang.Contains(tbKodeBarang.Text)).ToList();
                if (cariBarang.Count > 0 && cariBarang[0].KodeBarang != KodeTemp)
                {

                    MessageBox.Show("Kode barang tidak boleh sama!");
                    tbKodeBarang.Text = "";
                }
                else
                {
                    //edit data
                    daftarBarang[index].KodeBarang = tbKodeBarang.Text;
                    daftarBarang[index].NamaBarang = tbNamaBarang.Text;
                    daftarBarang[index].HargaBeli = tbHargaBeli.Text;
                    daftarBarang[index].HargaJual = tbHargaJual.Text;
                    daftarBarang[index].JumlahBarang = tbJumlah.Text;
                    daftarBarang[index].SatuanBarang = tbSatuan.Text;
                    MessageBox.Show("data berhasil di edit");
                    bindingSource.ResetBindings(false); //refresh datagridview
                    kondisiAwal();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Trim() == "" || tbNamaBarang.Text.Trim() == "" || tbHargaBeli.Text.Trim() == "" || tbHargaJual.Text.Trim() == "" || tbJumlah.Text.Trim() == "" || tbSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //hapus data
                daftarBarang.RemoveAt(index);
                MessageBox.Show("data berhasil di hapus");
                bindingSource.ResetBindings(false); //refresh datagridview
                kondisiAwal();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKodeBarang.Text))
            {
                //cari data didatalist
                var search = daftarBarang.Select((value, index) => new { Value = value, Index = index }).Where(x => x.Value.KodeBarang.Contains(tbKodeBarang.Text)).ToList();

                if (search.Count > 0)
                {
                    index = search[0].Index;
                    tbKodeBarang.Text = search[0].Value.KodeBarang;
                    tbNamaBarang.Text = search[0].Value.NamaBarang;
                    tbHargaBeli.Text = search[0].Value.HargaBeli;
                    tbHargaJual.Text = search[0].Value.HargaJual;
                    tbJumlah.Text = search[0].Value.JumlahBarang;
                    tbSatuan.Text = search[0].Value.SatuanBarang;
                    KodeTemp = search[0].Value.KodeBarang;
                }
                else
                {
                    MessageBox.Show("Data Barang Tidak Ada!!!");
                }
            }
        }

        private void tbHargaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        private void tbHargaJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        private void tbJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }
    }
}
