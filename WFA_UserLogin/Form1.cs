using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
        int starCount = 5;
        public Form1()
        {
            InitializeComponent();
        }


        private void txtGirisAlani_Click(object sender, EventArgs e)
        {
            // test
        }

        private void lblRastgeleSayi_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomGenerator();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!(txtGirisAlani.Text == lblRastgeleSayi.Text))
            {
                txtGirisAlani.Text = "";
                randomGenerator();
                MessageBox.Show("Error");
                return;
            }
            else
            {
                //starCounter();
                txtGirisAlani.Text = "";
                randomGenerator();
                MessageBox.Show("Success");
            }
        }

        public void randomGenerator()
        {
            Random random = new Random();
            int randomNo = random.Next(10000000, 99999999);
            lblRastgeleSayi.Text = randomNo.ToString();
        }

        public void starCounter()
        {
            if(!(starCount == 1))
            {
                starCount = starCount - 1;
            }
            else
            {
                btnLogin.Enabled = false;
                txtGirisAlani.Enabled = false;
                lblRastgeleSayi.Text = "********";
                MessageBox.Show("Game Error");
            }
        }

        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
