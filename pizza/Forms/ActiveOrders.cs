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
    public partial class ActiveOrders : Form
    {
        string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

        public ActiveOrders()
        {
            InitializeComponent();
            LoadAllOrders();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllOrders(string filter = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT o.OID, o.CustomerName, o.PhoneNo,
                        CONCAT(pf.FlavorName, ' (', ps.SizeName, ')') AS Pizza,
                        CONCAT(s.SaladName, ' (', sz.SizeName, ')') AS Salad,
                        CONCAT(di.DrinkName, ' (', ds.VolumeDescription, ')') AS Drink,
                        CONCAT(o.GovtTaxPercentage, '%') AS Tax,
                        o.TotalAmount AS Total,
                        o.OrderStatus AS Status,
                        o.DeliveredAt AS DeliveredTime
                    FROM Orders o
                    LEFT JOIN OrderPizzas op ON o.OID = op.OID
                    LEFT JOIN PizzaFlavors pf ON op.PizzaID = pf.PizzaID
                    LEFT JOIN PizzaSizes ps ON op.SizeID = ps.SizeID
                    LEFT JOIN OrderSalads os ON o.OID = os.OID
                    LEFT JOIN Salads s ON os.SaladID = s.SaladID
                    LEFT JOIN SaladSizes sz ON os.SizeID = sz.SizeID
                    LEFT JOIN OrderDrinks od ON o.OID = od.OID
                    LEFT JOIN DrinkItems di ON od.DrinkID = di.DrinkID
                    LEFT JOIN DrinkSizes ds ON od.DrinkSizeID = ds.DrinkSizeID
                    WHERE (@filter = '' OR o.OID = @oid OR o.CustomerName LIKE @name)
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@filter", filter);
                if (int.TryParse(filter, out int id))
                {
                    cmd.Parameters.AddWithValue("@oid", id);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@oid", -1); // Ensures no OID matches when filter is not a number
                }
                cmd.Parameters.AddWithValue("@name", "%" + filter + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = "";
            if (rdoPreparing.Checked) newStatus = "Preparing";
            else if (rdoReady.Checked) newStatus = "Ready";
            else if (rdoDelivered.Checked) newStatus = "Delivered";

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery;
                if (newStatus == "Delivered")
                {
                    updateQuery = "UPDATE Orders SET OrderStatus = @status, DeliveredAt = NOW() WHERE OID = @oid";
                }
                else
                {
                    updateQuery = "UPDATE Orders SET OrderStatus = @status, DeliveredAt = NULL WHERE OID = @oid";
                }

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@oid", oid);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllOrders();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadAllOrders();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadAllOrders(keyword);
        }
    }
}
