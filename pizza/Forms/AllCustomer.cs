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

            if (rowCount < 20)
            {
                MessageBox.Show("Export is only allowed when there are at least 20 delivered orders.", "Export Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"DeliveredOrders_{timestamp}.xlsx");

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Delivered Orders");

                    // Title
                    worksheet.Cell(1, 1).Value = "PizzaHut - Delivered Orders Report";
                    var titleRange = worksheet.Range(1, 1, 1, dataGridView1.Columns.Count);
                    titleRange.Merge().Style.Font.SetBold().Font.SetFontSize(14).Fill.SetBackgroundColor(XLColor.LightYellow);
                    titleRange.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Header row
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(2, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                        worksheet.Cell(2, i + 1).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);
                    }

                    // Data rows
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 3, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    worksheet.RangeUsed().SetAutoFilter();

                    workbook.SaveAs(filePath);
                }

                MessageBox.Show("Exported successfully to: " + filePath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ArchiveExportedOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadDeliveredOrders();
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            DateTime? from = dtpFrom.Checked ? dtpFrom.Value.Date : null;
            DateTime? to = dtpTo.Checked ? dtpTo.Value.Date : null;
            LoadDeliveredOrders(from, to);
        }

        private void lblTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
