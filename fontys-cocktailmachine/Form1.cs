using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace fontys_cocktailmachine
{
    public partial class Form1 : Form
    {
        private DataBase _connection;

        private List<Ingredient> _ingredients;
        private List<Recipe> _recipes;
        private List<Ingredient> recipe;

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
            string[] availablePort = SerialPort.GetPortNames();
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
            recipe = new List<Ingredient>();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "Back")
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


        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void lbDrinks_DoubleClick(object sender, EventArgs e)
        {
            int index = lbDrinks.SelectedIndex;
            recipe.Add(_ingredients[index]);
        }

        /// <summary>
        /// Returns a string that can be passed to the arduino for interpretation
        /// </summary>
        /// <param name="prefix">The prefix character</param>
        /// <param name="ingredient">Ingredient that needs execution</param>
        /// <returns>String that needs to be passed to arduino</returns>
        private string stringBuilder(char prefix, Ingredient ingredient)
        {
            return String.Format("{0}{1}", prefix, (char) ingredient.Id);
        }

        private void lbDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe selectedRecipe = _recipes[lbDrinks.SelectedIndex];

            foreach (Ingredient ingredient in selectedRecipe.Ingredients.Keys)
            {
                for (int i = 0; i != selectedRecipe.Ingredients[ingredient]; i++)
                {
                    recipe.Add(ingredient);
                }
            }
        }

        private void lbIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipe.Add(_ingredients[lbDrinks.SelectedIndex]);
        }
    }
}