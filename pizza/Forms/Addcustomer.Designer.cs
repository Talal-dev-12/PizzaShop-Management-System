namespace pizza.Forms
{
    partial class Addcustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            txtpizzaname = new Label();
            txtsalad = new Label();
            txtdrink = new Label();
            label69 = new Label();
            label9 = new Label();
            txtCustomerName = new TextBox();
            txtPhoneNo = new TextBox();
            cmbPizzaFlavor = new ComboBox();
            cmbSalad = new ComboBox();
            cmbDrinkSize = new ComboBox();
            btnback = new Button();
            btnexit = new Button();
            btnPlaceOrder = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPizzaSize = new ComboBox();
            cmbSaladSize = new ComboBox();
            cmbDrink = new ComboBox();
            txtGovtTax = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1060, 79);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(369, 102);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Customer Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(369, 129);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(60, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Phone No";
            // 
            // txtpizzaname
            // 
            txtpizzaname.AutoSize = true;
            txtpizzaname.Location = new Point(369, 165);
            txtpizzaname.Margin = new Padding(2, 0, 2, 0);
            txtpizzaname.Name = "txtpizzaname";
            txtpizzaname.Size = new Size(68, 15);
            txtpizzaname.TabIndex = 3;
            txtpizzaname.Text = "Pizza Name";
            // 
            // txtsalad
            // 
            txtsalad.AutoSize = true;
            txtsalad.Location = new Point(369, 228);
            txtsalad.Margin = new Padding(2, 0, 2, 0);
            txtsalad.Name = "txtsalad";
            txtsalad.Size = new Size(35, 15);
            txtsalad.TabIndex = 4;
            txtsalad.Text = "Salad";
            // 
            // txtdrink
            // 
            txtdrink.AutoSize = true;
            txtdrink.Location = new Point(369, 334);
            txtdrink.Margin = new Padding(2, 0, 2, 0);
            txtdrink.Name = "txtdrink";
            txtdrink.Size = new Size(84, 15);
            txtdrink.TabIndex = 5;
            txtdrink.Text = "Drink Volume :";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label69.Location = new Point(386, 379);
            label69.Margin = new Padding(2, 0, 2, 0);
            label69.Name = "label69";
            label69.Size = new Size(96, 25);
            label69.TabIndex = 6;
            label69.Text = "Govt Tax :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(419, 415);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 9;
            label9.Text = "Total :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(568, 94);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(164, 23);
            txtCustomerName.TabIndex = 10;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(568, 121);
            txtPhoneNo.Margin = new Padding(2);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(164, 23);
            txtPhoneNo.TabIndex = 13;
            // 
            // cmbPizzaFlavor
            // 
            cmbPizzaFlavor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaFlavor.FormattingEnabled = true;
            cmbPizzaFlavor.Location = new Point(568, 157);
            cmbPizzaFlavor.Margin = new Padding(2);
            cmbPizzaFlavor.Name = "cmbPizzaFlavor";
            cmbPizzaFlavor.Size = new Size(164, 23);
            cmbPizzaFlavor.TabIndex = 14;
            // 
            // cmbSalad
            // 
            cmbSalad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalad.FormattingEnabled = true;
            cmbSalad.Location = new Point(568, 220);
            cmbSalad.Margin = new Padding(2);
            cmbSalad.Name = "cmbSalad";
            cmbSalad.Size = new Size(164, 23);
            cmbSalad.TabIndex = 15;
            // 
            // cmbDrinkSize
            // 
            cmbDrinkSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrinkSize.FormattingEnabled = true;
            cmbDrinkSize.Location = new Point(568, 326);
            cmbDrinkSize.Margin = new Padding(2);
            cmbDrinkSize.Name = "cmbDrinkSize";
            cmbDrinkSize.Size = new Size(164, 23);
            cmbDrinkSize.TabIndex = 16;
            // 
            // btnback
            // 
            btnback.Location = new Point(11, 448);
            btnback.Margin = new Padding(2);
            btnback.Name = "btnback";
            btnback.Size = new Size(109, 37);
            btnback.TabIndex = 17;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(940, 448);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 37);
            btnexit.TabIndex = 18;
            btnexit.Text = "Close";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(437, 451);
            btnPlaceOrder.Margin = new Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(109, 37);
            btnPlaceOrder.TabIndex = 19;
            btnPlaceOrder.Text = "Add";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 296);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Drink";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 260);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 5;
            label4.Text = "Salad Size :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 195);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Pizza Size : ";
            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Location = new Point(568, 187);
            cmbPizzaSize.Margin = new Padding(2);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(164, 23);
            cmbPizzaSize.TabIndex = 14;
            // 
            // cmbSaladSize
            // 
            cmbSaladSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaladSize.FormattingEnabled = true;
            cmbSaladSize.Location = new Point(568, 252);
            cmbSaladSize.Margin = new Padding(2);
            cmbSaladSize.Name = "cmbSaladSize";
            cmbSaladSize.Size = new Size(164, 23);
            cmbSaladSize.TabIndex = 14;
            // 
            // cmbDrink
            // 
            cmbDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Location = new Point(568, 288);
            cmbDrink.Margin = new Padding(2);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(164, 23);
            cmbDrink.TabIndex = 15;
            // 
            // txtGovtTax
            // 
            txtGovtTax.BorderStyle = BorderStyle.None;
            txtGovtTax.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtGovtTax.Location = new Point(500, 381);
            txtGovtTax.Margin = new Padding(2);
            txtGovtTax.Name = "txtGovtTax";
            txtGovtTax.ReadOnly = true;
            txtGovtTax.Size = new Size(159, 26);
            txtGovtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtTotal.Location = new Point(500, 416);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(159, 26);
            txtTotal.TabIndex = 13;
            // 
            // Addcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 492);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(cmbDrinkSize);
            Controls.Add(cmbDrink);
            Controls.Add(cmbSalad);
            Controls.Add(cmbSaladSize);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaFlavor);
            Controls.Add(txtTotal);
            Controls.Add(txtGovtTax);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtCustomerName);
            Controls.Add(label9);
            Controls.Add(label69);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtdrink);
            Controls.Add(label5);
            Controls.Add(txtsalad);
            Controls.Add(txtpizzaname);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Addcustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addcustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private Label txtpizzaname;
        private Label txtsalad;
        private Label txtdrink;
        private Label label69;
        private Label label9;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNo;
        private ComboBox cmbPizzaFlavor;
        private ComboBox cmbSalad;
        private ComboBox cmbDrinkSize;
        private Button btnback;
        private Button btnexit;
        private Button btnPlaceOrder;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbPizzaSize;
        private ComboBox cmbSaladSize;
        private ComboBox cmbDrink;
        private TextBox txtGovtTax;
        private TextBox txtTotal;
    }
}