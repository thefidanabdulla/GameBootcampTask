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
            if (!(txtGirisAlani.Text == lblRastgeleSayi.Text))
            {
                if(!(starCount == 1))
                {
                    starCount = starCount - 1;
                    txtGirisAlani.Text = "";
                    randomGenerator();
                    
                    if (starCount == 4)
                        {
                            star5.Visible = false;
                        }
                    else if(starCount == 3)
                        {
                            star4.Visible = false;
                        }
                    else if (starCount == 2)
                        {
                            star3.Visible = false;
                        }
                    else if(starCount == 1)
                        {
                            star2.Visible = false;
                        }
                    return;
                }
                else
                {
                    starCount = 5;
                    btnLogin.Enabled = false;
                    txtGirisAlani.Enabled = false;
                    lblRastgeleSayi.Text = "********";
                    MessageBox.Show("Failed to login!"); 
                    if (starCount == 5)
                    {
                        star1.Visible = true;
                        star2.Visible = true;
                        star3.Visible = true;
                        star4.Visible = true;
                        star5.Visible = true;
                    }

                }
            }
            else
            {
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
            
        }

        // Randon Nesnesi kullanarak rastgele sayı üretilecek!
    }
}
