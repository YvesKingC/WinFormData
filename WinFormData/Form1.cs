namespace WinFormData
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        
            string[] Nama = new string[10];
            string[] Alamat = new string[10];
            string[] noTelp = new string[10];
        private void PassArrayToForm2()
        {
            if (Nama.Length > 0)
            {
                FormLihat1 formNama = new FormLihat1();
                formNama.liatarray(Nama);
            }
        }
        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

        private void btnLihatData_Click(object sender, EventArgs e)
            {
                this.Hide();
                FormLihat1 formLihat1 = new FormLihat1();
                formLihat1.Closed += (s, args) => this.Close();
                formLihat1.Show();

            }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < 9; i++)
                {
                    txtNama.Text = Nama[i];
                }
                for (int i = 0; i < 9; i++)
                {
                    txtAlamat.Text = Alamat[i];
                }
                for (int i = 0; i < 9; i++)
                {
                    txtNoTelp.Text = noTelp[i];
                }
        }
    }
}