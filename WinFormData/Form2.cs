using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormData
{
    public partial class FormLihat1 : Form
    {
        public FormLihat1()
        {
            InitializeComponent();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInput forminput = new FormInput();
            forminput.Closed += (s, args) => this.Close();
            forminput.Show();
        }
        public void liatarray(string[] array)
        {
            
        }
        private void FormLihat1_Load(object sender, EventArgs e)
        {
            FormInput forminput = new FormInput();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (btnKembali_Click != null)
            {
                string message = "eror";
                MessageBox.Show(message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext_Click != null)
            {
                
            }
        }
    }
}
