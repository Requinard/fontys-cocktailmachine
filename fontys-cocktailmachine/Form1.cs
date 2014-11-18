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
        List<int> customRecept;
        public Form1()
        {
            InitializeComponent();
            customRecept = new List<int>();
            btnStart.Visible = true;
            btnAlcohol.Visible = false;
            btnNonAlcohol.Visible = false;
            btnBack.Visible = false;
            btnSinaasappelsap.Visible = false;
            btnCola.Visible = false;
            btnTonic.Visible = false;

            btnVodka.Visible = false;
            btnGin.Visible = false;
            btnMartini.Visible = false;
            btnTequilla.Visible = false;
            btnRum.Visible = false;
            btnPerzik.Visible = false;

            btnDone.Visible = false;
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
            if (progressBar.Value == 100)
            {
                klaar();
            }
        }
        
        private void homeScreen()
            {
            btnStart.Visible = true;
            btnAlcohol.Visible = false;
            btnNonAlcohol.Visible = false;
            btnBack.Visible = false;
            btnSinaasappelsap.Visible = false;
            btnCola.Visible = false;
            btnTonic.Visible = false;

            btnVodka.Visible = false;
            btnGin.Visible = false;
            btnMartini.Visible = false;
            btnTequilla.Visible = false;
            btnRum.Visible = false;
            btnPerzik.Visible = false;

    }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnAlcohol.Visible = true;
            btnAlcohol.Enabled = true;
            btnNonAlcohol.Visible = true;
            btnNonAlcohol.Enabled = true;
            btnStart.Visible = false;
            btnBack.Visible = true;
            btnSinaasappelsap.Visible = false;
            btnCola.Visible = false;
            btnTonic.Visible = false;

            btnVodka.Visible = false;
            btnGin.Visible = false;
            btnMartini.Visible = false;
            btnTequilla.Visible = false;
            btnRum.Visible = false;
            btnPerzik.Visible = false;
            progressBar.Value = 0;
            progressBar.Visible = true;


           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnAlcohol.Visible)
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
            btnSinaasappelsap.Visible = true;
            btnCola.Visible = true;
            btnTonic.Visible = true;

            btnAlcohol.Enabled = true;
            btnVodka.Visible = false;
            btnGin.Visible = false;
            btnMartini.Visible = false;
            btnTequilla.Visible = false;
            btnRum.Visible = false;
            btnPerzik.Visible = false;

        }

        private void btnAlcohol_Click(object sender, EventArgs e)
        {
            btnAlcohol.Enabled = false;
            btnVodka.Visible = true;
            btnGin.Visible = true;
            btnMartini.Visible = true;
            btnTequilla.Visible = true;
            btnRum.Visible = true;
            btnPerzik.Visible = true;

            btnNonAlcohol.Enabled = true;
            btnSinaasappelsap.Visible = false;
            btnCola.Visible = false;
            btnTonic.Visible = false;
            
           }




        private void klaar()
        {
            //code naar arduino

        }

        private void btnCola_Click(object sender, EventArgs e)
        { 
            customRecept.Add(0);
            fill();
        }

        private void btnSinaasappelsap_Click(object sender, EventArgs e)
        {
            customRecept.Add(1);
            fill();
        }

        private void btnTonic_Click(object sender, EventArgs e)
        {
            customRecept.Add(2);
            fill();
        }








     }
}
