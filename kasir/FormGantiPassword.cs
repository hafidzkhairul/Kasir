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
    public partial class FormGantiPassword : Form
    {
        public FormGantiPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbPwOld.Text != FormLogin.PasswordKasir)
            {
                MessageBox.Show("Password salah!");
            }
            else
            {
                if (tbPwNew.Text.Trim() == "")
                {
                    MessageBox.Show("Password baru tidak boleh kosong!");
                }
                else
                {
                    FormLogin.daftarKasir[FormLogin.index].PasswordKasir = tbPwNew.Text;
                    MessageBox.Show("Password berhasil diganti.");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
