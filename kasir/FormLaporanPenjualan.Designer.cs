namespace kasir
{
    partial class FormLaporanPenjualan
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
            label1 = new Label();
            dateStart = new DateTimePicker();
            dateEnd = new DateTimePicker();
            label2 = new Label();
            btnFind = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            btnReset = new Button();
            lblTotalTrans = new Label();
            lblTotalPendap = new Label();
            label7 = new Label();
            btnCetak = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Tanggal : ";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(91, 33);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 23);
            dateStart.TabIndex = 1;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(359, 33);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 23);
            dateEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 39);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "s/d";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(588, 31);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(89, 30);
            btnFind.TabIndex = 4;
            btnFind.Text = "Cari";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 160);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 369);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(748, 150);
            dataGridView2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 351);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Detail Transaksi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 77);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Hasil";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(683, 31);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 30);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblTotalTrans
            // 
            lblTotalTrans.AutoSize = true;
            lblTotalTrans.Location = new Point(27, 102);
            lblTotalTrans.Name = "lblTotalTrans";
            lblTotalTrans.Size = new Size(90, 15);
            lblTotalTrans.TabIndex = 10;
            lblTotalTrans.Text = "Total Transaksi :";
            // 
            // lblTotalPendap
            // 
            lblTotalPendap.AutoSize = true;
            lblTotalPendap.Location = new Point(27, 126);
            lblTotalPendap.Name = "lblTotalPendap";
            lblTotalPendap.Size = new Size(108, 15);
            lblTotalPendap.TabIndex = 11;
            lblTotalPendap.Text = "Total Pendapatan : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 151);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 12;
            label7.Text = "List Transaksi :";
            // 
            // btnCetak
            // 
            btnCetak.Enabled = false;
            btnCetak.Location = new Point(326, 538);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(122, 52);
            btnCetak.TabIndex = 13;
            btnCetak.Text = "CETAK";
            btnCetak.UseVisualStyleBackColor = true;
            btnCetak.Click += btnCetak_Click;
            // 
            // FormLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 639);
            Controls.Add(btnCetak);
            Controls.Add(label7);
            Controls.Add(lblTotalPendap);
            Controls.Add(lblTotalTrans);
            Controls.Add(btnReset);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnFind);
            Controls.Add(dateEnd);
            Controls.Add(label2);
            Controls.Add(dateStart);
            Controls.Add(label1);
            Name = "FormLaporanPenjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporanPenjualan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private Label label2;
        private Button btnFind;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private Button btnReset;
        private Label lblTotalTrans;
        private Label lblTotalPendap;
        private Label label7;
        private Button btnCetak;
    }
}