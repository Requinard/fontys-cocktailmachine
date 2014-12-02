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
            HomeScreen();
          

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
        
        private void HomeScreen()
            {
            btnStart.Visible = true;
            lbDrinks.Visible = false;
            lbIngr.Visible = false;
            btnBack.Text = "Exit";
            btnBack.Visible = true;
            btnDone.Visible = false;
            

    }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            lbDrinks.Visible = true;
            lbIngr.Visible = true;
            btnBack.Text = "Back";
            btnBack.Visible = true;
            btnDone.Visible = false;
            eigenRecept = new List<char>();



        }
        private void btnBack_Click(object sender, EventArgs e)
        {

        if      (btnBack.Text == "Back")
            {
                HomeScreen();
            }
        else if (btnBack.Text == "Exit")
            {
                Close();
            }
        } 



        //private void toArduino(string dinges)
        //{
        //    MessageBox.Show("Lost arduino Connection, ERROR 4y2i4.dll is missing.");
        //}


        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void lbDrinks_DoubleClick(object sender, EventArgs e)
        {

        }

       

        


        }
     }
