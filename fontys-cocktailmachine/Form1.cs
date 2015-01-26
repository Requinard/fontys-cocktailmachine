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
        private const int MAXAANTALINGREDIENTEN = 5;
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
            btnSend.Visible = false;
            btnZelfgemaakt.Visible = false;
            btnVoorgemaakte.Visible = false;
            btnDeleteIng.Visible = false;
            lbRecipe.Visible = false;
            btnDeleteDrink.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnVoorgemaakte.Visible = true;
            btnZelfgemaakt.Visible = true;
            btnStart.Visible = false;            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            recipe.Clear();
            SetListboxToRecipe();

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
            SetListboxToRecipe();
        }

        private void lbIngr_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipe.Add(_ingredients[lbIngr.SelectedIndex]);
            SetListboxToRecipe();
          
        }

        private void SetListboxToRecipe()
        {
            lbRecipe.Items.Clear();
            foreach (var ingr in recipe)
            {
                lbRecipe.Items.Add(ingr.Name);
            }
            if (recipe.Count >= MAXAANTALINGREDIENTEN)
            {
                lbIngr.Enabled = false;
                lbDrinks.Enabled = false;
                lblMaxBereikt.Visible = true;
            }
            else
            {
                lbIngr.Enabled = true;
                lbIngr.Enabled = true;
                lblMaxBereikt.Visible = false;
            }
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
            if (!lbIngr.Enabled)
            {
                lbIngr.Enabled = true; 
            }
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
                MessageBox.Show("Something went wrong during arduino IO. Please reboot the application");
                return false;
            }

            return true;
        }

        private void btnZelfgemaakt_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            lbDrinks.Visible = false;
            lbIngr.Visible = true;
            btnBack.Text = "Back";
            btnBack.Visible = true;
            btnDone.Visible = false;
            btnSend.Visible = true;
            btnVoorgemaakte.Visible = false;
            btnZelfgemaakt.Visible = false;
            btnDeleteIng.Visible = true;
            lbRecipe.Visible = true;
            btnDeleteDrink.Visible = false;
            
            recipe = new List<Ingredient>();
        }

        private void btnVoorgemaakte_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            lbDrinks.Visible = true;
            lbIngr.Visible = false;
            btnBack.Text = "Back";
            btnBack.Visible = true;
            btnDone.Visible = false;
            btnSend.Visible = true;
            btnVoorgemaakte.Visible = false;
            btnZelfgemaakt.Visible = false;
            recipe = new List<Ingredient>();
            lbRecipe.Visible = true;
            btnDeleteDrink.Visible = true;
            lbDrinks.Enabled = true;
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            if (lbRecipe.SelectedItem == null)
            {
                MessageBox.Show("Nothing was selected");
            }
            else
            {
                recipe.RemoveAt(lbRecipe.SelectedIndex);
                SetListboxToRecipe();
            }
            
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            recipe.Clear();
            SetListboxToRecipe();
            lbDrinks.Enabled = true;
        }
    }
}