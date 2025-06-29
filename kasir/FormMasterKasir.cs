using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir
{
    public partial class FormMasterKasir : Form
    {
        FormLogin FormLogin = new FormLogin();
        BindingSource bindingSource = new BindingSource();
        private int index;
        string KodeTemp;
        private Button btnSearch;

        void munculLevel()
        {
            cbLevel.Items.Add("ADMIN");
            cbLevel.Items.Add("KASIR");
        }

        void kondisiAwal()
        {
            tbKode.Text = "";
            tbNama.Text = "";
            tbPasswordKasir.Text = "";
            cbLevel.Text = "";
        }

        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbKode = new TextBox();
            tbNama = new TextBox();
            tbPasswordKasir = new TextBox();
            cbLevel = new ComboBox();
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
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 0;
            label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 70);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 1;
            label2.Text = "Nama Kasir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 105);
            label3.Name = "label3";
            label3.Size = new Size(135, 22);
            label3.TabIndex = 2;
            label3.Text = "Password Kasir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 139);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 3;
            label4.Text = "Level Kasir";
            // 
            // tbKode
            // 
            tbKode.Location = new Point(167, 35);
            tbKode.Name = "tbKode";
            tbKode.Size = new Size(157, 28);
            tbKode.TabIndex = 4;
            tbKode.KeyPress += textBox1_KeyPress;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(167, 70);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(399, 28);
            tbNama.TabIndex = 5;
            // 
            // tbPasswordKasir
            // 
            tbPasswordKasir.Location = new Point(167, 102);
            tbPasswordKasir.Name = "tbPasswordKasir";
            tbPasswordKasir.Size = new Size(157, 28);
            tbPasswordKasir.TabIndex = 6;
            // 
            // cbLevel
            // 
            cbLevel.FormattingEnabled = true;
            cbLevel.Location = new Point(167, 139);
            cbLevel.Name = "cbLevel";
            cbLevel.Size = new Size(157, 30);
            cbLevel.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnInput);
            groupBox1.Location = new Point(26, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 73);
            groupBox1.TabIndex = 8;
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
            dataGridView1.Location = new Point(26, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(508, 169);
            dataGridView1.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(330, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 24);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormMasterKasir
            // 
            BackColor = Color.DarkCyan;
            ClientSize = new Size(591, 432);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(cbLevel);
            Controls.Add(tbPasswordKasir);
            Controls.Add(tbNama);
            Controls.Add(tbKode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMasterKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Kasir";
            Load += FormMasterKasir_Load;
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbKode;
        private TextBox tbNama;
        private TextBox tbPasswordKasir;
        private ComboBox cbLevel;
        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnInput;
        private DataGridView dataGridView1;
        private Label label4;


        void munculDataKasir()
        {
            //load data kasir
            bindingSource.DataSource = FormLogin.daftarKasir;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            kondisiAwal();
            munculDataKasir();
            munculLevel();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbKode.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbPasswordKasir.Text.Trim() == "" || cbLevel.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //cek kode kasir tidak boleh sama
                var cariUser = FormLogin.daftarKasir.Where(ksr => ksr.KodeKasir.Contains(tbKode.Text)).ToList();
                if (cariUser.Count > 0)
                {
                    MessageBox.Show("Kode kasir tidak boleh sama!");
                    tbKode.Text = "";
                }else
                {
                    //input data
                    FormLogin.AddDataKasir(tbKode.Text, tbNama.Text, tbPasswordKasir.Text, cbLevel.Text);
                    MessageBox.Show("data berhasil di input");
                    bindingSource.ResetBindings(false); //refresh datagridview
                    kondisiAwal();
                }
            }
        }

        //press enter di textbox kode untuk search data
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbKode.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbPasswordKasir.Text.Trim() == "" || cbLevel.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //cek kode kasir
                var cariUser = FormLogin.daftarKasir.Where(ksr => ksr.KodeKasir.Contains(tbKode.Text)).ToList();
                if (cariUser.Count > 0 && cariUser[0].KodeKasir != KodeTemp)
                {

                    MessageBox.Show("Kode kasir tidak boleh sama!");
                    tbKode.Text = "";
                }
                else
                {
                    //edit data
                    FormLogin.UpdateDataKasir(index, tbKode.Text, tbNama.Text, tbPasswordKasir.Text, cbLevel.Text);
                    MessageBox.Show("data berhasil di edit");
                    bindingSource.ResetBindings(false); //refresh datagridview
                    kondisiAwal();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tbKode.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbPasswordKasir.Text.Trim() == "" || cbLevel.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                //hapus data
                FormLogin.DeleteDataKasir(index);
                MessageBox.Show("data berhasil di hapus");
                bindingSource.ResetBindings(false); //refresh datagridview
                kondisiAwal();
            }
        }

        //search data kasir
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKode.Text))
            {
                //cari data di datalist by kode kasir
                var search = FormLogin.daftarKasir.Select((value, index) => new { Value = value, Index = index }).Where(x => x.Value.KodeKasir.Contains(tbKode.Text)).ToList();

                if (search.Count > 0)
                {
                    index = search[0].Index;
                    tbKode.Text = search[0].Value.KodeKasir;
                    tbNama.Text = search[0].Value.NamaKasir;
                    tbPasswordKasir.Text = search[0].Value.PasswordKasir;
                    cbLevel.Text = search[0].Value.LevelKasir;
                    KodeTemp = search[0].Value.KodeKasir;
                }
                else
                {
                    MessageBox.Show("Data Kasir Tidak Ada!!!");
                }
            }
        }
    }
}