namespace kasir
{
    partial class FormMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuUtama));
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            menuKasir = new ToolStripMenuItem();
            menuBarang = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            menuPenjualan = new ToolStripMenuItem();
            menuLaporan = new ToolStripMenuItem();
            menuLapPenjualan = new ToolStripMenuItem();
            menuUtility = new ToolStripMenuItem();
            menuGantiPassword = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster, menuTransaksi, menuLaporan, menuUtility });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1321, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, toolStripMenuItem1, exitToolStripMenuItem });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(54, 29);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(171, 34);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(171, 34);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(171, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { menuKasir, menuBarang });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(82, 29);
            menuMaster.Text = "Master";
            // 
            // menuKasir
            // 
            menuKasir.Name = "menuKasir";
            menuKasir.Size = new Size(169, 34);
            menuKasir.Text = "Kasir";
            menuKasir.Click += menuKasir_Click;
            // 
            // menuBarang
            // 
            menuBarang.Name = "menuBarang";
            menuBarang.Size = new Size(169, 34);
            menuBarang.Text = "Barang";
            menuBarang.Click += menuBarang_Click;
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { menuPenjualan });
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(98, 29);
            menuTransaksi.Text = "Transaksi";
            // 
            // menuPenjualan
            // 
            menuPenjualan.Name = "menuPenjualan";
            menuPenjualan.Size = new Size(188, 34);
            menuPenjualan.Text = "Penjualan";
            menuPenjualan.Click += menuPenjualan_Click;
            // 
            // menuLaporan
            // 
            menuLaporan.DropDownItems.AddRange(new ToolStripItem[] { menuLapPenjualan });
            menuLaporan.Name = "menuLaporan";
            menuLaporan.Size = new Size(92, 29);
            menuLaporan.Text = "Laporan";
            // 
            // menuLapPenjualan
            // 
            menuLapPenjualan.Name = "menuLapPenjualan";
            menuLapPenjualan.Size = new Size(188, 34);
            menuLapPenjualan.Text = "Penjualan";
            menuLapPenjualan.Click += menuLapPenjualan_Click;
            // 
            // menuUtility
            // 
            menuUtility.DropDownItems.AddRange(new ToolStripItem[] { menuGantiPassword, menuAbout });
            menuUtility.Name = "menuUtility";
            menuUtility.Size = new Size(73, 29);
            menuUtility.Text = "Utility";
            // 
            // menuGantiPassword
            // 
            menuGantiPassword.Name = "menuGantiPassword";
            menuGantiPassword.Size = new Size(235, 34);
            menuGantiPassword.Text = "Ganti Password";
            menuGantiPassword.Click += menuGantiPassword_Click;
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(235, 34);
            menuAbout.Text = "About";
            menuAbout.Click += menuAbout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(337, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1321, 711);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuUtama";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuKasir;
        private ToolStripMenuItem menuBarang;
        private ToolStripMenuItem menuPenjualan;
        private ToolStripMenuItem menuLapPenjualan;
        private ToolStripMenuItem menuGantiPassword;
        private ToolStripMenuItem menuAbout;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuLaporan;
        public ToolStripMenuItem menuUtility;
        private PictureBox pictureBox1;
    }
}