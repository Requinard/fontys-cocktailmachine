using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fontys_cocktailmachine
{
    public partial class Form1 : Form
    {
        private List<char> eigenRecept;
        private DataBase _connection;

        public Form1()
        {
            InitializeComponent();

            InitializeSerialPort();

            InitializeDatabase();
        }

        private void InitializeSerialPort()
        {
            string[] availablePort = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in availablePort)
            {
                serialPort.PortName = port;
                serialPort.Open();
                string response = serialPort.ReadLine();
                if (response != null)
                {
                    return;
                }
                serialPort.Close();
            }
            MessageBox.Show("No Arduino Found");
        }

        private void InitializeDatabase()
        {
            _connection = new DataBase();
            DataSet ds = _connection.QueryDatabase("SELECT * FROM ingredients");
            
        }

        private void fillAllotedAmountBar()
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
        
        private void setUpHomeScreen()
            {
            btnStart.Visible = true;
            btnAlcohol.Visible = false;
            btnNonAlcohol.Visible = false;
            btnBack.Visible = true;

            gbNonAlcohol.Visible = false;
            gbAlcohol.Visible = false;
            progressBar.Visible = false;
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
            btnBack.Text = "Back";

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
                setUpHomeScreen();
                btnBack.Text = "Back";
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
            while (eigenRecept.Count() < 6)
                {
                    eigenRecept.Add((char)90);
                }
            
            for (int i = 0; i < eigenRecept.Count(); i++)
                {
                   int nozzle = eigenRecept[i];
                   arduinoCode(nozzle);
                }
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)65);
            fillAllotedAmountBar();
        }

        private void btnSinaasappelsap_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)66);
            fillAllotedAmountBar();
        }

        private void btnTonic_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)67);
            fillAllotedAmountBar();
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)68);
            fillAllotedAmountBar();
        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)69);
            fillAllotedAmountBar();
        }

        private void btnGin_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)70);
            fillAllotedAmountBar();
        }

        private void btnPerzik_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)71);
            fillAllotedAmountBar();
        }

        private void btnMartini_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)72);
            fillAllotedAmountBar();
        }

        private void btnTequilla_Click(object sender, EventArgs e)
        {
            eigenRecept.Add((char)73);
            fillAllotedAmountBar();
        }

        private void toArduino(string input)
        {
            try
            {
                serialPort.WriteLine(input);
            }
            catch(Exception)
            {
                MessageBox.Show("Arduino not connected, ERROR253. Call Company");
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
     }
}
