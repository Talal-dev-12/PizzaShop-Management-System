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

namespace pizza.Forms
{
    public partial class Updatecustomer : Form
    {
        public Updatecustomer()
        {
            InitializeComponent();
            LoadComboBoxes();

        }
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
        string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";
        private void LoadComboBoxes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter pizzaFlavors = new MySqlDataAdapter("SELECT PizzaID, FlavorName FROM PizzaFlavors", conn);
                DataTable dtPizza = new DataTable();
                pizzaFlavors.Fill(dtPizza);
                dtPizza.Rows.InsertAt(dtPizza.NewRow(), 0);
                dtPizza.Rows[0]["FlavorName"] = "-- Select Flavor --";
                cmbPizzaFlavor.DataSource = dtPizza;
                cmbPizzaFlavor.DisplayMember = "FlavorName";
                cmbPizzaFlavor.ValueMember = "PizzaID";

                MySqlDataAdapter pizzaSizes = new MySqlDataAdapter("SELECT SizeID, SizeName FROM PizzaSizes", conn);
                DataTable dtSize = new DataTable();
                pizzaSizes.Fill(dtSize);
                dtSize.Rows.InsertAt(dtSize.NewRow(), 0);
                dtSize.Rows[0]["SizeName"] = "-- Select Size --";
                cmbPizzaSize.DataSource = dtSize;
                cmbPizzaSize.DisplayMember = "SizeName";
                cmbPizzaSize.ValueMember = "SizeID";
                cmbPizzaSize.Enabled = false;

                MySqlDataAdapter drinkNames = new MySqlDataAdapter("SELECT DrinkID, DrinkName FROM DrinkItems", conn);
                DataTable dtDrinks = new DataTable();
                drinkNames.Fill(dtDrinks);
                dtDrinks.Rows.InsertAt(dtDrinks.NewRow(), 0);
                dtDrinks.Rows[0]["DrinkName"] = "-- Select Drink --";
                cmbDrink.DataSource = dtDrinks;
                cmbDrink.DisplayMember = "DrinkName";
                cmbDrink.ValueMember = "DrinkID";

                MySqlDataAdapter drinkSizes = new MySqlDataAdapter("SELECT DrinkSizeID, VolumeDescription FROM DrinkSizes", conn);
                DataTable dtDrinkSizes = new DataTable();
                drinkSizes.Fill(dtDrinkSizes);
                dtDrinkSizes.Rows.InsertAt(dtDrinkSizes.NewRow(), 0);
                dtDrinkSizes.Rows[0]["VolumeDescription"] = "-- Select Size --";
                cmbDrinkSize.DataSource = dtDrinkSizes;
                cmbDrinkSize.DisplayMember = "VolumeDescription";
                cmbDrinkSize.ValueMember = "DrinkSizeID";
                cmbDrinkSize.Enabled = false;

                MySqlDataAdapter saladNames = new MySqlDataAdapter("SELECT SaladID, SaladName FROM Salads", conn);
                DataTable dtSalad = new DataTable();
                saladNames.Fill(dtSalad);
                dtSalad.Rows.InsertAt(dtSalad.NewRow(), 0);
                dtSalad.Rows[0]["SaladName"] = "-- Select Salad --";
                cmbSalad.DataSource = dtSalad;
                cmbSalad.DisplayMember = "SaladName";
                cmbSalad.ValueMember = "SaladID";

                MySqlDataAdapter saladSizes = new MySqlDataAdapter("SELECT SizeID, SizeName FROM SaladSizes", conn);
                DataTable dtSaladSizes = new DataTable();
                saladSizes.Fill(dtSaladSizes);
                dtSaladSizes.Rows.InsertAt(dtSaladSizes.NewRow(), 0);
                dtSaladSizes.Rows[0]["SizeName"] = "-- Select Size --";
                cmbSaladSize.DataSource = dtSaladSizes;
                cmbSaladSize.DisplayMember = "SizeName";
                cmbSaladSize.ValueMember = "SizeID";
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


        private bool ValidateOrderSelections()
        {
            if (cmbPizzaFlavor.SelectedIndex > 0 && cmbPizzaSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Pizza Size.");
                return false;
            }
            if (cmbSalad.SelectedIndex > 0 && cmbSaladSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Salad Size.");
                return false;
            }
            if (cmbDrink.SelectedIndex > 0 && cmbDrinkSize.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Drink Size.");
                return false;
            }
            return true;
        }

        private void AutoCalculate(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderid.Text))
            {
                MessageBox.Show("Please enter Order ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";
            string oid = txtOrderid.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Read from Orders table
                string orderQuery = "SELECT * FROM Orders WHERE OID = @id";
                using (MySqlCommand cmd = new MySqlCommand(orderQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", oid);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCustomerName.Text = reader["CustomerName"].ToString();
                            txtPhoneNo.Text = reader["PhoneNo"].ToString();
                            txtTotal.Text = reader["TotalAmount"].ToString();
                            txtGovtTax.Text = reader["GovtTaxPercentage"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Order not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                // Step 2: Load Pizza Info
                string pizzaQuery = "SELECT PizzaID, SizeID FROM OrderPizzas WHERE OID = @oid LIMIT 1";
                using (MySqlCommand pizzaCmd = new MySqlCommand(pizzaQuery, conn))
                {
                    pizzaCmd.Parameters.AddWithValue("@oid", oid);
                    using (MySqlDataReader pizzaReader = pizzaCmd.ExecuteReader())
                    {
                        if (pizzaReader.Read())
                        {
                            cmbPizzaFlavor.SelectedValue = pizzaReader["PizzaID"].ToString();
                            cmbPizzaSize.SelectedValue = pizzaReader["SizeID"].ToString();
                        }
                    }
                }

                // Step 3: Load Salad Info
                string saladQuery = "SELECT SaladID, SizeID FROM OrderSalads WHERE OID = @oid LIMIT 1";
                using (MySqlCommand saladCmd = new MySqlCommand(saladQuery, conn))
                {
                    saladCmd.Parameters.AddWithValue("@oid", oid);
                    using (MySqlDataReader saladReader = saladCmd.ExecuteReader())
                    {
                        if (saladReader.Read())
                        {
                            cmbSalad.SelectedValue = saladReader["SaladID"].ToString();
                            cmbSaladSize.SelectedValue = saladReader["SizeID"].ToString();
                        }
                    }
                }

                // Step 4: Load Drink Info
                string drinkQuery = "SELECT DrinkID, DrinkSizeID FROM OrderDrinks WHERE OID = @oid LIMIT 1";
                using (MySqlCommand drinkCmd = new MySqlCommand(drinkQuery, conn))
                {
                    drinkCmd.Parameters.AddWithValue("@oid", oid);
                    using (MySqlDataReader drinkReader = drinkCmd.ExecuteReader())
                    {
                        if (drinkReader.Read())
                        {
                            cmbDrink.SelectedValue = drinkReader["DrinkID"].ToString();
                            cmbDrinkSize.SelectedValue = drinkReader["DrinkSizeID"].ToString();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateOrderSelections()) return;
            if (string.IsNullOrWhiteSpace(txtOrderid.Text))
            {
                MessageBox.Show("Order ID is required for update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please enter both Customer Name and Phone Number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPhoneNo.Text.Length != 13)
            {
                MessageBox.Show("Phone number must be in format +92XXXXXXXXXX (13 characters).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal totalAmount))
            {
                MessageBox.Show("Please calculate total amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateOrderQuery = "UPDATE Orders SET CustomerName = @name, PhoneNo = @phone, GovtTaxPercentage = @tax, TotalAmount = @total WHERE OID = @oid";
                using (MySqlCommand cmd = new MySqlCommand(updateOrderQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@tax", 10);
                    cmd.Parameters.AddWithValue("@total", totalAmount);
                    cmd.Parameters.AddWithValue("@oid", txtOrderid.Text);
                    cmd.ExecuteNonQuery();
                }

                string oid = txtOrderid.Text;

                // Delete previous item entries
                new MySqlCommand($"DELETE FROM OrderPizzas WHERE OID = {oid}", conn).ExecuteNonQuery();
                new MySqlCommand($"DELETE FROM OrderDrinks WHERE OID = {oid}", conn).ExecuteNonQuery();
                new MySqlCommand($"DELETE FROM OrderSalads WHERE OID = {oid}", conn).ExecuteNonQuery();

                // Re-insert pizza
                if (cmbPizzaFlavor.SelectedIndex > 0 && cmbPizzaSize.SelectedIndex > 0)
                {
                    MySqlCommand pizzaInsert = new MySqlCommand(@"INSERT INTO OrderPizzas 
                        (OID, PizzaID, SizeID, Quantity, Price) 
                        SELECT @oid, @pizzaId, @sizeId, 1, FinalPrice 
                        FROM PizzaPrices 
                        WHERE PizzaID = @pizzaId AND SizeID = @sizeId", conn);
                    pizzaInsert.Parameters.AddWithValue("@oid", oid);
                    pizzaInsert.Parameters.AddWithValue("@pizzaId", cmbPizzaFlavor.SelectedValue);
                    pizzaInsert.Parameters.AddWithValue("@sizeId", cmbPizzaSize.SelectedValue);
                    pizzaInsert.ExecuteNonQuery();
                }

                // Re-insert drink
                if (cmbDrink.SelectedIndex > 0 && cmbDrinkSize.SelectedIndex > 0)
                {
                    MySqlCommand drinkInsert = new MySqlCommand(@"INSERT INTO OrderDrinks 
                        (OID, DrinkID, DrinkSizeID, Quantity, Price) 
                        SELECT @oid, @drinkId, @sizeId, 1, FinalPrice 
                        FROM DrinkPrices 
                        WHERE DrinkID = @drinkId AND DrinkSizeID = @sizeId", conn);
                    drinkInsert.Parameters.AddWithValue("@oid", oid);
                    drinkInsert.Parameters.AddWithValue("@drinkId", cmbDrink.SelectedValue);
                    drinkInsert.Parameters.AddWithValue("@sizeId", cmbDrinkSize.SelectedValue);
                    drinkInsert.ExecuteNonQuery();
                }

                // Re-insert salad
                if (cmbSalad.SelectedIndex > 0 && cmbSaladSize.SelectedIndex > 0)
                {
                    MySqlCommand saladInsert = new MySqlCommand(@"INSERT INTO OrderSalads 
                        (OID, SaladID, SizeID, Quantity, Price) 
                        SELECT @oid, @saladId, @sizeId, 1, (s.Price * ss.SizeMultiplier) 
                        FROM Salads s 
                        JOIN SaladSizes ss ON ss.SizeID = @sizeId 
                        WHERE s.SaladID = @saladId LIMIT 1", conn);
                    saladInsert.Parameters.AddWithValue("@oid", oid);
                    saladInsert.Parameters.AddWithValue("@saladId", cmbSalad.SelectedValue);
                    saladInsert.Parameters.AddWithValue("@sizeId", cmbSaladSize.SelectedValue);
                    saladInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
