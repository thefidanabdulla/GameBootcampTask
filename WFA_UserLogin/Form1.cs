using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            if (!(txtGirisAlani.Text == lblRastgeleSayi.Text))
            {
                if(!(starCount == 1))
                {
                    starCount = starCount - 1;
                    txtGirisAlani.Text = "";
                    randomGenerator();
                    txtGirisAlani.Focus();
                    switch (starCount)
                    {
                        case 4:
                            star5.Visible = false;
                            break;
                        case 3:
                            star4.Visible = false;
                            break;
                        case 2:
                            star3.Visible = false;
                            break;
                        case 1:
                            star2.Visible = false;
                            break;
                        default:
                            break;
                    }
                    return;
                }
                else
                {
                    btnLogin.Enabled = false;
                    txtGirisAlani.Enabled = false;
                    lblRastgeleSayi.Text = "********";
                    MessageBox.Show("Failed to login!");
                    startAgain();

                }
            }
            else
            {
                txtGirisAlani.Text = "";
                randomGenerator();
                startAgain();
                MessageBox.Show("Welcome :)");
            }
        }

        public void startAgain()
        {
            starCount = 5;
            if (starCount == 5)
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
                star5.Visible = true;
            }
        }

        public void randomGenerator()
        {
            Random random = new Random();
            int randomNo = random.Next(10000000, 99999999);
            lblRastgeleSayi.Text = randomNo.ToString();
        }

        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
