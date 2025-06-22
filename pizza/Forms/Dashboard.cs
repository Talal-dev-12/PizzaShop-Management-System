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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            Addcustomer AddCustomerForm = new Addcustomer();
            AddCustomerForm.ShowDialog();
        }

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            Updatecustomer updateCustomerForm = new Updatecustomer();
            updateCustomerForm.ShowDialog();
        }

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            Deletecustomer deleteCustomerForm = new Deletecustomer();
            deleteCustomerForm.ShowDialog();
        }

        //  private void btnsearchcustomer_Click(object sender, EventArgs e)
        //{
        //  searchcustomer searchCustomerForm = new searchcustomer();
        //searchCustomerForm.ShowDialog();
        //}

        private void btndisplaydata_Click(object sender, EventArgs e)
        {
            ActiveOrders displayDataForm = new ActiveOrders();
            displayDataForm.ShowDialog();
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            AddInventory form = new AddInventory();
            form.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearchcustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
