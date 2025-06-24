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
using ClosedXML.Excel;
using System.IO;

namespace pizza.Forms
{
    public partial class Deletecustomer : Form
    {
        string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

        public Deletecustomer()
        {
            InitializeComponent();
            LoadDeliveredOrders();
        }
        private void Deletecustomer_Load(object sender, EventArgs e)
        {

        }
        private void LoadDeliveredOrders(DateTime? fromDate = null, DateTime? toDate = null)
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
                        o.DeliveredAt
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
                    WHERE o.OrderStatus = 'Delivered'
                      AND o.IsArchived = 0
                     AND (@from IS NULL OR o.DeliveredAt >= @from)
                     AND (@to IS NULL OR o.DeliveredAt <= @to)
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", fromDate.HasValue ? fromDate.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@to", toDate.HasValue ? toDate.Value : (object)DBNull.Value);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ClearSelection();

                // Update summary labels
                decimal totalSale = 0;
                int totalOrders = dt.Rows.Count;

                foreach (DataRow row in dt.Rows)
                {
                    if (decimal.TryParse(row["Total"].ToString(), out decimal amount))
                    {
                        totalSale += amount;
                    }
                }

                lblTotalSales.Text = "Rs. " + totalSale.ToString("N0");
                lblTotalOrders.Text = totalOrders.ToString();
            }
        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void ArchiveExportedOrders()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE Orders SET IsArchived = 1 WHERE OrderStatus = 'Delivered'";
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.ExecuteNonQuery();
            }
            LoadDeliveredOrders();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseComObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnExportToExcel_Click_1(object sender, EventArgs e)
        {

            int rowCount = dataGridView1.Rows.Count;

            if (rowCount == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }
            else if (rowCount < 20)
            {
                MessageBox.Show("Cannot export. Minimum 20 delivered orders are required for export.", "Export Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Do you want to export the delivered orders to Excel?", "Export Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save Delivered Orders Report";
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveDialog.FileName = DateTime.Now.ToString("HH-mm_dd-MM-yy") + " Report.xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Delivered Orders");

                            worksheet.Cell(1, 1).Value = "PizzaHut - Delivered Orders Report";
                            var titleRange = worksheet.Range(1, 1, 1, dataGridView1.Columns.Count);
                            titleRange.Merge().Style.Font.SetBold().Font.SetFontSize(14).Fill.SetBackgroundColor(XLColor.LightYellow);
                            titleRange.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(2, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                                worksheet.Cell(2, i + 1).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);
                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 3, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            worksheet.Columns().AdjustToContents();
                            worksheet.RangeUsed().SetAutoFilter();

                            workbook.SaveAs(saveDialog.FileName);
                        }

                        MessageBox.Show("Exported successfully to:\n" + saveDialog.FileName, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ArchiveExportedOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadDeliveredOrders();
            dataGridView1.ClearSelection();
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {

            DateTime? from = dtpFrom.Checked ? dtpFrom.Value.Date : null;
            DateTime? to = dtpTo.Checked ? dtpTo.Value.Date : null;
            LoadDeliveredOrders(from, to);
            dataGridView1.ClearSelection();
        }

        private void lblTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to archive the selected orders?", "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int oid = Convert.ToInt32(row.Cells["OID"].Value);
                            string updateQuery = "UPDATE Orders SET IsArchived = 1 WHERE OID = @OID";
                            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@OID", oid);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Selected orders archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDeliveredOrders();
                }
            }
            else
            {
                DialogResult warn = MessageBox.Show("⚠ No row selected. This will archive ALL delivered orders.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn == DialogResult.Yes)
                {
                    string password = Microsoft.VisualBasic.Interaction.InputBox("Enter admin password to proceed:", "Admin Confirmation", "");
                    if (password == "admin")
                    {
                        ArchiveExportedOrders();
                        MessageBox.Show("All delivered orders archived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Action aborted.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
