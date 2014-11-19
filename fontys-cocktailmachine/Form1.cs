using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fontys_cocktailmachine
{
    public partial class Form1 : Form
    {
        List<char> customRecept;
        public Form1()
        {
            InitializeComponent();
            customRecept = new List<char>();
            btnStart.Visible = true;
            btnDone.Visible = false;
            btnBack.Visible = true;

            btnAlcohol.Visible = false;
            btnNonAlcohol.Visible = false;

            gbNonAlcohol.Visible = false;
            gbAlcohol.Visible = false;
            
        }
        private void fill()
        {
            if (progressBar.Value + 25 <= 150)
            {
                progressBar.Value = progressBar.Value + 25;
            }
            else
            {
                progressBar.Value = progressBar.Maximum;
            }
            btnDone.Visible = true;
            if (progressBar.Value == 150)
            {
                orderComplete();
            }
        }
        
        private void homeScreen()
            {
            btnStart.Visible = true;
            btnAlcohol.Visible = false;
            btnNonAlcohol.Visible = false;
            btnBack.Visible = true;

            gbNonAlcohol.Visible = false;
            gbAlcohol.Visible = false;
            progressBar.Value = 0;



    }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnAlcohol.Visible = true;
            btnAlcohol.Enabled = true;
            btnNonAlcohol.Visible = true;
            btnNonAlcohol.Enabled = true;
            btnStart.Visible = false;
            btnBack.Visible = true;

            gbNonAlcohol.Visible = false;
            gbAlcohol.Visible = false;
            
            progressBar.Visible = true;


           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   if (btnStart.Visible)
            {
                Close();
            }
            if (btnAlcohol.Visible && btnNonAlcohol.Visible)
            {
                homeScreen();
            }
            if (btnAlcohol.Enabled == false || btnNonAlcohol.Enabled == false)
            {
                btnStart_Click(sender, e);
            }
            
        }

        private void btnNonAlcohol_Click(object sender, EventArgs e)
        {
            btnNonAlcohol.Enabled = false;
            gbNonAlcohol.Visible = true;

            btnAlcohol.Enabled = true;
            gbAlcohol.Visible = false;

        }

        private void btnAlcohol_Click(object sender, EventArgs e)
        {
            btnNonAlcohol.Enabled = true;
            gbNonAlcohol.Visible = false;

            btnAlcohol.Enabled = false;
            gbAlcohol.Visible = true;
           }

        public void arduinoCode(int nozzle)
        {
            //code arduino

        }


        private void orderComplete()
        {
            while (customRecept.Count() < 6)
                {
                    customRecept.Add((char)90);
                }
            
            for (int i = 0; i < customRecept.Count(); i++)
                {
                   int nozzle = customRecept[i];
                   arduinoCode(nozzle);
                }
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)65);
            fill();
        }

        private void btnSinaasappelsap_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)66);
            fill();
        }

        private void btnTonic_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)67);
            fill();
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)68);
            fill();
        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)69);
            fill();
        }

        private void btnGin_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)70);
            fill();
        }

        private void btnPerzik_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)71);
            fill();
        }

        private void btnMartini_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)72);
            fill();
        }

        private void btnTequilla_Click(object sender, EventArgs e)
        {
            customRecept.Add((char)73);
            fill();
        }
     }
}
