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
    public partial class AddInventory : Form
    {
        string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

        public AddInventory()
        {
            InitializeComponent();
            
        }
        private void AddInventory_Load(object sender, EventArgs e)
        {
            LoadPizzaInventory();
            LoadDrinkInventory();
            LoadSaladInventory();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPizzaInventory()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT pf.FlavorName, ps.SizeName, inv.Quantity
                                 FROM PizzaInventory inv
                                 JOIN PizzaFlavors pf ON inv.PizzaID = pf.PizzaID
                                 JOIN PizzaSizes ps ON inv.SizeID = ps.SizeID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridPizzaInventory.DataSource = dt;
            }
        }

        private void LoadDrinkInventory()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT di.DrinkName, ds.VolumeDescription, inv.Quantity
                                 FROM DrinkInventory inv
                                 JOIN DrinkItems di ON inv.DrinkID = di.DrinkID
                                 JOIN DrinkSizes ds ON inv.DrinkSizeID = ds.DrinkSizeID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridDrinkInventory.DataSource = dt;
            }
        }

        private void LoadSaladInventory()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT s.SaladName, ss.SizeName, inv.Quantity
                                 FROM SaladInventory inv
                                 JOIN Salads s ON inv.SaladID = s.SaladID
                                 JOIN SaladSizes ss ON inv.SizeID = ss.SizeID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridSaladInventory.DataSource = dt;
            }
        }

        private void btnAddPizzaStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO PizzaInventory (PizzaID, SizeID, Quantity) VALUES (@pid, @sid, @qty)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", cmbPizzaFlavor.SelectedValue);
                cmd.Parameters.AddWithValue("@sid", cmbPizzaSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtPizzaQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadPizzaInventory();
            }
        }

        private void btnUpdatePizzaStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE PizzaInventory SET Quantity = @qty WHERE PizzaID = @pid AND SizeID = @sid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", cmbPizzaFlavor.SelectedValue);
                cmd.Parameters.AddWithValue("@sid", cmbPizzaSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtPizzaQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadPizzaInventory();
            }
        }

        private void btnDeletePizzaStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM PizzaInventory WHERE PizzaID = @pid AND SizeID = @sid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", cmbPizzaFlavor.SelectedValue);
                cmd.Parameters.AddWithValue("@sid", cmbPizzaSize.SelectedValue);
                cmd.ExecuteNonQuery();
                LoadPizzaInventory();
            }
        }

        private void btnAddDrinkStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DrinkInventory (DrinkID, DrinkSizeID, Quantity) VALUES (@did, @dsid, @qty)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@did", cmbDrinkName.SelectedValue);
                cmd.Parameters.AddWithValue("@dsid", cmbDrinkSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtDrinkQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadDrinkInventory();
            }
        }

        private void btnUpdateDrinkStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DrinkInventory SET Quantity = @qty WHERE DrinkID = @did AND DrinkSizeID = @dsid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@did", cmbDrinkName.SelectedValue);
                cmd.Parameters.AddWithValue("@dsid", cmbDrinkSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtDrinkQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadDrinkInventory();
            }
        }

        private void btnDeleteDrinkStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DrinkInventory WHERE DrinkID = @did AND DrinkSizeID = @dsid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@did", cmbDrinkName.SelectedValue);
                cmd.Parameters.AddWithValue("@dsid", cmbDrinkSize.SelectedValue);
                cmd.ExecuteNonQuery();
                LoadDrinkInventory();
            }
        }

        private void btnAddSaladStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SaladInventory (SaladID, SizeID, Quantity) VALUES (@sid, @szid, @qty)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", cmbSaladName.SelectedValue);
                cmd.Parameters.AddWithValue("@szid", cmbSaladSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtSaladQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadSaladInventory();
            }
        }

        private void btnUpdateSaladStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE SaladInventory SET Quantity = @qty WHERE SaladID = @sid AND SizeID = @szid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", cmbSaladName.SelectedValue);
                cmd.Parameters.AddWithValue("@szid", cmbSaladSize.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtSaladQty.Text.Trim()));
                cmd.ExecuteNonQuery();
                LoadSaladInventory();
            }
        }

        private void btnDeleteSaladStock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SaladInventory WHERE SaladID = @sid AND SizeID = @szid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", cmbSaladName.SelectedValue);
                cmd.Parameters.AddWithValue("@szid", cmbSaladSize.SelectedValue);
                cmd.ExecuteNonQuery();
                LoadSaladInventory();
            }
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            LoadPizzaInventory();
            LoadDrinkInventory();
            LoadSaladInventory();
        }

    }
}
