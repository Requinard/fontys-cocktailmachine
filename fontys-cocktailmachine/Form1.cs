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

        private List<Ingredient> _ingredients;
        private List<Recipe> _recipes; 

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeDatabase();

            _ingredients = _connection.CreateIngredientList();
            _recipes = _connection.CreateRecipeList(_ingredients);
            HomeScreen();
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
            
        }
        
        private void HomeScreen()
            {
            btnStart.Visible = true;

    }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

            

        private void toArduino(string dinges)
        {
            MessageBox.Show("Lost arduino Connection, ERROR 4y2i4.dll is missing.");
        }


        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            string selectedIndex = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedIndex);
        }


        }
     }
