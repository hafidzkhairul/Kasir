using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kasir
{
    public partial class FormLaporanPenjualan : Form
    {
        int totalPendapatan = 0;
        int totalTransaksi = 0;
        
        public FormLaporanPenjualan()
        {
            InitializeComponent();
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.CustomFormat = "dd/MM/yyyy";
            dateStart.MaxDate = DateTime.Today;

            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.CustomFormat = "dd/MM/yyyy";
            dateEnd.MaxDate = DateTime.Today;
            resetDate();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime start = dateStart.Value.Date;
            DateTime end = dateEnd.Value.Date;

            var filtered = FormTransJual.penjualan.Where(dte => dte.TglJual.Date >= start && dte.TglJual.Date <= end).ToList();

            totalPendapatan = 0;
            totalTransaksi = 0;

            if (filtered.Count > 0)
            {
                foreach (var item in filtered)
                {
                    totalPendapatan += item.TotalJual;
                }
                totalTransaksi += filtered.Count;
                btnCetak.Enabled = true;
            }
            else
            {
                btnCetak.Enabled = false;
            }
            lblTotalPendap.Text = $"Total Pendapatan : {totalPendapatan.ToString()}";
            lblTotalTrans.Text = $"Total Transaksi : {totalTransaksi.ToString()}";


            dataGridView1.DataSource = filtered;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetDate();
        }

        private void resetDate()
        {
            dateEnd.Value = DateTime.Today;
            dateStart.Value = new DateTime(2025, 1, 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris yang diklik valid (bukan header)
            if (e.RowIndex >= 0)
            {
                // Ambil sel di kolom pertama (indeks 0) pada baris yang diklik
                var NoJual = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();

                var detail = FormTransJual.detailJual.Where(brg => brg.NoJual.Contains(NoJual)).ToList();

                dataGridView2.DataSource = detail;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            DateTime start = dateStart.Value.Date;
            DateTime end = dateEnd.Value.Date;

            var filtered = FormTransJual.penjualan.Where(dte => dte.TglJual.Date >= start && dte.TglJual.Date <= end).ToList();
            // Membuka dialog untuk menyimpan file

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt"; // Hanya format .txt
            saveFileDialog.Title = "Laporan Penjualan"; // Judul dialog
            saveFileDialog.FileName = $"Laporan Penjualan({start.ToString("dd_MM_yyyy")} - {end.ToString("dd_MM_yyyy")})";

            // Jika user memilih lokasi dan menekan Save
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Menulis file teks pada lokasi yang dipilih
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Menulis informasi buku ke dalam file
                    writer.WriteLine("                                        LAPORAN PENJUALAN");
                    writer.WriteLine($"                                Periode : {dateStart.Text} s/d {dateEnd.Text}");
                    writer.WriteLine();
                    writer.WriteLine("------------------------------------------------------------------------------------------------");
                    writer.WriteLine($"Total Transaksi  : {totalTransaksi}");
                    writer.WriteLine($"Total Pendapatan : {totalPendapatan.ToString("N0")}");
                    writer.WriteLine($"Detail Transaksi :");
                    foreach(var item in filtered)
                    {
                        var kasir = FormLogin.daftarKasir.Where(x => x.KodeKasir.Contains(item.KodeKasir)).ToList();
                        string nameksr = kasir.Count == 0 ? item.KodeKasir : kasir[0].NamaKasir;
                        writer.WriteLine("  -------------------------------------------------------------------------------------------");
                        writer.WriteLine(" | No Jual  | Tanggal              | Total        | DiBayar      | Kembali     | Kasir       |");
                        writer.WriteLine("  -------------------------------------------------------------------------------------------");
                        writer.WriteLine($"   {item.NoJual.PadRight(9)}  {item.TglJual.ToString().PadRight(21)}  {item.TotalJual.ToString("N0").PadRight(13)}  {item.diBayar.ToString("N0").PadRight(13)}  {item.Kembali.ToString("N0").PadRight(12)}  {nameksr}");
                        writer.WriteLine();
                        writer.WriteLine("                -----------------------------------------------------------------------------");
                        writer.WriteLine("  Detail -->   | Kode Barang   | Nama Barang          | Harga     | Jumlah    | Subtotal     |");
                        writer.WriteLine("                -----------------------------------------------------------------------------");
                        var detail = FormTransJual.detailJual.Where(x => x.NoJual.Contains(item.NoJual)).ToList();
                        foreach(var dtl in detail)
                        {
                            writer.WriteLine($"                 {dtl.KodeBarang.PadRight(14)}  {dtl.NamaBarang.PadRight(21)}  {dtl.HargaBarang.ToString("N0").PadRight(10)}  {dtl.JumlahJual.ToString().PadRight(10)}  {dtl.SubTotal.ToString("N0")}");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Laporan berhasil disimpan!");
            }
        }
    }
}
