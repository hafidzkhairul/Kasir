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
            label1.Location = new Point(82, 45);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Password Lama";
            // 
            // tbPwOld
            // 
            tbPwOld.Location = new Point(82, 63);
            tbPwOld.Name = "tbPwOld";
            tbPwOld.Size = new Size(235, 23);
            tbPwOld.TabIndex = 1;
            // 
            // tbPwNew
            // 
            tbPwNew.Location = new Point(82, 122);
            tbPwNew.Name = "tbPwNew";
            tbPwNew.Size = new Size(235, 23);
            tbPwNew.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 104);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 2;
            label2.Text = "Masukkan Password Baru";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(100, 167);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(216, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormGantiPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 306);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(tbPwNew);
            Controls.Add(label2);
            Controls.Add(tbPwOld);
            Controls.Add(label1);
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