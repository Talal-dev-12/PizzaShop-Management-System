using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using pizza.Database;

namespace pizza.Forms
{
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();
            LoadComboBoxes();
            txtPhoneNo.Text = "+92";
            txtPhoneNo.SelectionStart = txtPhoneNo.Text.Length;
            txtPhoneNo.KeyPress += TxtPhoneNo_KeyPress;
            txtPhoneNo.TextChanged += TxtPhoneNo_TextChanged;
        }
        string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

       
        private void TxtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block non-digit input except control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limit to exactly 10 digits after +92 (total 13 characters)
            if (txtPhoneNo.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            // Ensure +92 is always present
            if (!txtPhoneNo.Text.StartsWith("+92"))
            {
                int cursor = txtPhoneNo.SelectionStart;
                txtPhoneNo.Text = "+92";
                txtPhoneNo.SelectionStart = txtPhoneNo.Text.Length;
            }
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
        private void LoadComboBoxes()
        {
            string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Pizza Flavors
                MySqlDataAdapter pizzaFlavors = new MySqlDataAdapter("SELECT FlavorName FROM PizzaFlavors", conn);
                DataTable dtPizza = new DataTable();
                pizzaFlavors.Fill(dtPizza);
                dtPizza.Rows.InsertAt(dtPizza.NewRow(), 0);
                dtPizza.Rows[0]["FlavorName"] = "-- Select Flavor --";
                cmbPizzaFlavor.DataSource = dtPizza;
                cmbPizzaFlavor.DisplayMember = "FlavorName";

                // Pizza Sizes
                MySqlDataAdapter pizzaSizes = new MySqlDataAdapter("SELECT SizeName FROM PizzaSizes", conn);
                DataTable dtSize = new DataTable();
                pizzaSizes.Fill(dtSize);
                dtSize.Rows.InsertAt(dtSize.NewRow(), 0);
                dtSize.Rows[0]["SizeName"] = "-- Select Size --";
                cmbPizzaSize.DataSource = dtSize;
                cmbPizzaSize.DisplayMember = "SizeName";
                cmbPizzaSize.Enabled = false;

                // Drink Names
                MySqlDataAdapter drinkNames = new MySqlDataAdapter("SELECT DrinkName FROM DrinkItems", conn);
                DataTable dtDrinks = new DataTable();
                drinkNames.Fill(dtDrinks);
                dtDrinks.Rows.InsertAt(dtDrinks.NewRow(), 0);
                dtDrinks.Rows[0]["DrinkName"] = "-- Select Drink --";
                cmbDrink.DataSource = dtDrinks;
                cmbDrink.DisplayMember = "DrinkName";

                // Drink Sizes
                MySqlDataAdapter drinkSizes = new MySqlDataAdapter("SELECT VolumeDescription FROM DrinkSizes", conn);
                DataTable dtDrinkSizes = new DataTable();
                drinkSizes.Fill(dtDrinkSizes);
                dtDrinkSizes.Rows.InsertAt(dtDrinkSizes.NewRow(), 0);
                dtDrinkSizes.Rows[0]["VolumeDescription"] = "-- Select Size --";
                cmbDrinkSize.DataSource = dtDrinkSizes;
                cmbDrinkSize.DisplayMember = "VolumeDescription";
                cmbDrinkSize.Enabled = false;

                // Salads
                MySqlDataAdapter saladNames = new MySqlDataAdapter("SELECT SaladName FROM Salads", conn);
                DataTable dtSalad = new DataTable();
                saladNames.Fill(dtSalad);
                dtSalad.Rows.InsertAt(dtSalad.NewRow(), 0);
                dtSalad.Rows[0]["SaladName"] = "-- Select Salad --";
                cmbSalad.DataSource = dtSalad;
                cmbSalad.DisplayMember = "SaladName";

                // Salad Sizes
                MySqlDataAdapter saladSizes = new MySqlDataAdapter("SELECT SizeName FROM SaladSizes", conn);
                DataTable dtSaladSizes = new DataTable();
                saladSizes.Fill(dtSaladSizes);
                dtSaladSizes.Rows.InsertAt(dtSaladSizes.NewRow(), 0);
                dtSaladSizes.Rows[0]["SizeName"] = "-- Select Size --";
                cmbSaladSize.DataSource = dtSaladSizes;
                cmbSaladSize.DisplayMember = "SizeName";
                cmbSaladSize.Enabled = false;
            }

            cmbPizzaFlavor.SelectedIndexChanged += (s, e) =>
            {
                cmbPizzaSize.Enabled = cmbPizzaFlavor.SelectedIndex > 0;
                if (!cmbPizzaSize.Enabled) cmbPizzaSize.SelectedIndex = 0;
                AutoCalculate(s, e);
            };

            cmbPizzaSize.SelectedIndexChanged += AutoCalculate;

            cmbDrink.SelectedIndexChanged += (s, e) =>
            {
                cmbDrinkSize.Enabled = cmbDrink.SelectedIndex > 0;
                if (!cmbDrinkSize.Enabled) cmbDrinkSize.SelectedIndex = 0;
                AutoCalculate(s, e);
            };

            cmbDrinkSize.SelectedIndexChanged += AutoCalculate;

            cmbSalad.SelectedIndexChanged += (s, e) =>
            {
                cmbSaladSize.Enabled = cmbSalad.SelectedIndex > 0;
                if (!cmbSaladSize.Enabled) cmbSaladSize.SelectedIndex = 0;
                AutoCalculate(s, e);
            };

            cmbSaladSize.SelectedIndexChanged += AutoCalculate;
        }

        private void AutoCalculate(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        private bool ValidateOrderSelections()
        {
            // Validate Pizza Combo Selection
            if (cmbPizzaFlavor.SelectedIndex > 0 && cmbPizzaSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Pizza Size.");
                return false;
            }

            // Validate Salad Combo Selection
            if (cmbSalad.SelectedIndex > 0 && cmbSaladSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Salad Size.");
                return false;
            }

            // Validate Drink Combo Selection
            if (cmbDrink.SelectedIndex > 0 && cmbDrinkSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Drink Size.");
                return false;
            }

            return true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal pizzaPrice = 0, drinkPrice = 0, saladPrice = 0, tax = 0, total = 0;
            decimal taxRate = 10.0m; 


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlCommand pizzaCmd = new MySqlCommand("SELECT FinalPrice FROM PizzaPrices pp JOIN PizzaFlavors pf ON pf.PizzaID = pp.PizzaID JOIN PizzaSizes ps ON ps.SizeID = pp.SizeID WHERE pf.FlavorName = @flavor AND ps.SizeName = @size", conn);
                pizzaCmd.Parameters.AddWithValue("@flavor", cmbPizzaFlavor.Text);
                pizzaCmd.Parameters.AddWithValue("@size", cmbPizzaSize.Text);
                pizzaPrice = Convert.ToDecimal(pizzaCmd.ExecuteScalar() ?? 0);

                MySqlCommand drinkCmd = new MySqlCommand("SELECT FinalPrice FROM DrinkPrices dp JOIN DrinkItems di ON di.DrinkID = dp.DrinkID JOIN DrinkSizes ds ON ds.DrinkSizeID = dp.DrinkSizeID WHERE di.DrinkName = @drink AND ds.VolumeDescription = @volume", conn);
                drinkCmd.Parameters.AddWithValue("@drink", cmbDrink.Text);
                drinkCmd.Parameters.AddWithValue("@volume", cmbDrinkSize.Text);
                drinkPrice = Convert.ToDecimal(drinkCmd.ExecuteScalar() ?? 0);

                MySqlCommand saladCmd = new MySqlCommand("SELECT s.Price * ss.SizeMultiplier FROM Salads s JOIN SaladSizes ss ON 1=1 WHERE s.SaladName = @salad AND ss.SizeName = @size LIMIT 1", conn);
                saladCmd.Parameters.AddWithValue("@salad", cmbSalad.Text);
                saladCmd.Parameters.AddWithValue("@size", cmbSaladSize.Text);
                saladPrice = Convert.ToDecimal(saladCmd.ExecuteScalar() ?? 0);
            }

            
            total = pizzaPrice + drinkPrice + saladPrice + tax;
            tax = (pizzaPrice + drinkPrice + saladPrice) * (taxRate / 100m);

            txtGovtTax.Text = $"{taxRate}% ({tax:F2})";
            txtTotal.Text = total.ToString("F2");
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderSelections()) return;

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please enter both Customer Name and Phone Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTotal.Text) || !decimal.TryParse(txtTotal.Text, out decimal totalAmount))
            {
                MessageBox.Show("Please select at least one item to place the order.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPhoneNo.Text.Length != 13)
            {
                MessageBox.Show("Phone number must be in format +92XXXXXXXXXX (13 characters total).", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlCommand orderCmd = new MySqlCommand("INSERT INTO Orders (CustomerName, PhoneNo, GovtTaxPercentage, TotalAmount) VALUES (@name, @phone, @tax, @total); SELECT LAST_INSERT_ID();", conn);
                orderCmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                orderCmd.Parameters.AddWithValue("@phone", txtPhoneNo.Text);
                orderCmd.Parameters.AddWithValue("@tax", 10.00m); 
                orderCmd.Parameters.AddWithValue("@total", totalAmount);

                int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                // Only insert pizza if selected
                if (cmbPizzaFlavor.SelectedIndex > 0 && cmbPizzaSize.SelectedIndex > 0)
                {
                    MySqlCommand pizzaInsert = new MySqlCommand(@"INSERT INTO OrderPizzas 
                (OID, PizzaID, SizeID, Quantity, Price) 
                SELECT @oid, pf.PizzaID, ps.SizeID, 1, pp.FinalPrice 
                FROM PizzaFlavors pf 
                JOIN PizzaPrices pp ON pf.PizzaID = pp.PizzaID 
                JOIN PizzaSizes ps ON ps.SizeID = pp.SizeID 
                WHERE pf.FlavorName = @flavor AND ps.SizeName = @size", conn);
                    pizzaInsert.Parameters.AddWithValue("@oid", orderId);
                    pizzaInsert.Parameters.AddWithValue("@flavor", cmbPizzaFlavor.Text);
                    pizzaInsert.Parameters.AddWithValue("@size", cmbPizzaSize.Text);
                    pizzaInsert.ExecuteNonQuery();
                }

                // Only insert drink if selected
                if (cmbDrink.SelectedIndex > 0 && cmbDrinkSize.SelectedIndex > 0)
                {
                    MySqlCommand drinkInsert = new MySqlCommand(@"INSERT INTO OrderDrinks 
                (OID, DrinkID, DrinkSizeID, Quantity, Price) 
                SELECT @oid, di.DrinkID, ds.DrinkSizeID, 1, dp.FinalPrice 
                FROM DrinkItems di 
                JOIN DrinkPrices dp ON di.DrinkID = dp.DrinkID 
                JOIN DrinkSizes ds ON ds.DrinkSizeID = dp.DrinkSizeID 
                WHERE di.DrinkName = @drink AND ds.VolumeDescription = @size", conn);
                    drinkInsert.Parameters.AddWithValue("@oid", orderId);
                    drinkInsert.Parameters.AddWithValue("@drink", cmbDrink.Text);
                    drinkInsert.Parameters.AddWithValue("@size", cmbDrinkSize.Text);
                    drinkInsert.ExecuteNonQuery();
                }

                // Only insert salad if selected
                if (cmbSalad.SelectedIndex > 0 && cmbSaladSize.SelectedIndex > 0)
                {
                    MySqlCommand saladInsert = new MySqlCommand(@"INSERT INTO OrderSalads 
                (OID, SaladID, SizeID, Quantity, Price) 
                SELECT @oid, s.SaladID, ss.SizeID, 1, (s.Price * ss.SizeMultiplier) 
                FROM Salads s 
                JOIN SaladSizes ss ON 1=1 
                WHERE s.SaladName = @salad AND ss.SizeName = @size LIMIT 1", conn);
                    saladInsert.Parameters.AddWithValue("@oid", orderId);
                    saladInsert.Parameters.AddWithValue("@salad", cmbSalad.Text);
                    saladInsert.Parameters.AddWithValue("@size", cmbSaladSize.Text);
                    saladInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Addcustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
