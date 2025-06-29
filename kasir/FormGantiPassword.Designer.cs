namespace kasir
{
    partial class FormGantiPassword
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
            tbPwOld = new TextBox();
            tbPwNew = new TextBox();
            label2 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 22);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Password Lama";
            // 
            // tbPwOld
            // 
            tbPwOld.Location = new Point(117, 93);
            tbPwOld.Margin = new Padding(4, 5, 4, 5);
            tbPwOld.Name = "tbPwOld";
            tbPwOld.Size = new Size(334, 28);
            tbPwOld.TabIndex = 1;
            // 
            // tbPwNew
            // 
            tbPwNew.Location = new Point(117, 178);
            tbPwNew.Margin = new Padding(4, 5, 4, 5);
            tbPwNew.Name = "tbPwNew";
            tbPwNew.Size = new Size(334, 28);
            tbPwNew.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 22);
            label2.TabIndex = 2;
            label2.Text = "Masukkan Password Baru";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(143, 244);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 33);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(309, 244);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormGantiPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(546, 449);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(tbPwNew);
            Controls.Add(label2);
            Controls.Add(tbPwOld);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGantiPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGantiPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbPwOld;
        private TextBox tbPwNew;
        private Label label2;
        private Button btnSubmit;
        private Button btnCancel;
    }
}