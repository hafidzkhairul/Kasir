using System.Data;

namespace kasir
{
    public partial class FormLogin : Form
    {
        public static List<User> daftarKasir = new List<User>();
        public static string KodeKasir = "";
        public static string NamaKasir = "";
        public static string PasswordKasir = "";
        public static string LevelKasir = "";
        public static int index;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cari data kasir
            //var cariUser = daftarKasir.Where(ksr => ksr.KodeKasir.Contains(textBox1.Text)).ToList();
            var cariUser = daftarKasir.Select((value, index) => new { Value = value, Index = index }).Where(x => x.Value.KodeKasir.Equals(tbKode.Text)).ToList();

            if (cariUser.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan!");
                return;
            }

            if (cariUser.Count > 0 && cariUser[0].Value.PasswordKasir != tbPassword.Text)
            {
                MessageBox.Show("Password Salah");
                return;
            }

            KodeKasir = cariUser[0].Value.KodeKasir;
            NamaKasir = cariUser[0].Value.NamaKasir;
            PasswordKasir = cariUser[0].Value.PasswordKasir;
            LevelKasir = cariUser[0].Value.LevelKasir;
            index = cariUser[0].Index;
            FormMenuUtama.menu.menuLogin.Enabled = false;
            FormMenuUtama.menu.menuLogout.Enabled = true;
            //Menu master hanya bisa dibuka oleh admin 
            if (LevelKasir.Trim() == "ADMIN")
            {
                FormMenuUtama.menu.menuMaster.Enabled = true;
            }
            else
            {
                FormMenuUtama.menu.menuMaster.Enabled = false;
            }
            FormMenuUtama.menu.menuTransaksi.Enabled = true;
            FormMenuUtama.menu.menuLaporan.Enabled = true;
            FormMenuUtama.menu.menuUtility.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void kasirStarted()
        {
            daftarKasir = new List<User>{
                new User
                {
                    KodeKasir = "ADM001",
                    NamaKasir = "ADMIN",
                    PasswordKasir = "ADMIN",
                    LevelKasir = "ADMIN"
                },
                new User
                {
                    KodeKasir = "KSR001",
                    NamaKasir = "KASIR",
                    PasswordKasir = "KASIR",
                    LevelKasir = "KASIR"
                }
            };
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            tbKode.Text = "ADM001";
            tbPassword.Text = "ADMIN";
        }

        public void AddDataKasir(string kode, string nama, string pass, string level)
        {
            User user = new User
            {
                KodeKasir = kode,
                NamaKasir = nama,
                PasswordKasir = pass,
                LevelKasir = level
            };
            daftarKasir.Add(user);
        }

        public void UpdateDataKasir(int index, string kode, string nama, string pass, string level)
        {
            daftarKasir[index].KodeKasir = kode;
            daftarKasir[index].NamaKasir = nama;
            daftarKasir[index].PasswordKasir = pass;
            daftarKasir[index].LevelKasir = level;
        }


        public void DeleteDataKasir(int index)
        {
            daftarKasir.RemoveAt(index);
        }

        //enter ketika focus di textbox kode maka fokus akan pindah ke textbox password
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                tbPassword.Focus();
            }
        }

        //enter ketika focus di textbox password maka trigger btn login
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }
    }
}
