using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace fontys_cocktailmachine
{
    public partial class Form1 : Form
    {
        private readonly List<Ingredient> _ingredients;
        private readonly List<Recipe> _recipes;
        private DataBase _connection;
        private List<Ingredient> recipe;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeDatabase();

            _ingredients = _connection.CreateIngredientList();
            _recipes = _connection.CreateRecipeList(_ingredients);

            initializeIngredientList();
            initializeRecipeList();

            HomeScreen();
        }

        private void initializeRecipeList()
        {
            lbDrinks.Items.Clear();
            foreach (Recipe item in _recipes)
            {
                lbDrinks.Items.Add(item.Name);
            }
        }

        private void initializeIngredientList()
        {
            lbIngr.Items.Clear();
            foreach (Ingredient item in _ingredients)
            {
                lbIngr.Items.Add(item.Name);
            }
        }


        private void InitializeSerialPort()
        {
            string[] availablePort = SerialPort.GetPortNames();
            foreach (string port in availablePort)
            {
                serialPort.PortName = port;
                serialPort.Open();
            }
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

        /// <summary>
        ///     Returns a string that can be passed to the arduino for interpretation
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
            recipe.Add(_ingredients[lbIngr.SelectedIndex]);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Ingredient ingredient in recipe)
            {
                string command = stringBuilder('x', ingredient);

                if (!serialWrite(command))
                {
                    Close();
                    return;
                }
            }

            recipe.Clear();
        }

        /// <summary>
        ///     Send a string over the serial port and wait for acknowledge
        /// </summary>
        /// <param name="write">String that needs to be sent</param>
        /// <returns>If it returns false, something went wrong during this application</returns>
        private bool serialWrite(string write)
        {
            // Write to the serial port
            try
            {
                serialPort.WriteLine(write);

                // Wait for a response
                while (true)
                {
                    if (serialPort.ReadLine().Contains("ack"))
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somethign went wrong during arduino IO. Please reboot the application");
                return false;
            }

            return true;
        }
    }
}