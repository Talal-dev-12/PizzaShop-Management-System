namespace pizza.Forms
{
    partial class Updatecustomer
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
            btnUpdate = new Button();
            btnexit = new Button();
            cmbDrinkSize = new ComboBox();
            cmbDrink = new ComboBox();
            cmbSalad = new ComboBox();
            cmbSaladSize = new ComboBox();
            cmbPizzaSize = new ComboBox();
            cmbPizzaFlavor = new ComboBox();
            txtTotal = new TextBox();
            txtGovtTax = new TextBox();
            txtPhoneNo = new TextBox();
            txtCustomerName = new TextBox();
            label9 = new Label();
            label69 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtdrink = new Label();
            label5 = new Label();
            txtsalad = new Label();
            txtpizzaname = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            txtOrderid = new TextBox();
            label2 = new Label();
            btnSearchs = new Button();
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
            label1.TabIndex = 38;
            label1.Text = "UPDATE CUSTOMER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(467, 453);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 30);
            btnUpdate.TabIndex = 61;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(945, 455);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(104, 28);
            btnexit.TabIndex = 60;
            btnexit.Text = "Close";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // cmbDrinkSize
            // 
            cmbDrinkSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrinkSize.FormattingEnabled = true;
            cmbDrinkSize.Location = new Point(557, 363);
            cmbDrinkSize.Margin = new Padding(2);
            cmbDrinkSize.Name = "cmbDrinkSize";
            cmbDrinkSize.Size = new Size(164, 23);
            cmbDrinkSize.TabIndex = 58;
            // 
            // cmbDrink
            // 
            cmbDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Location = new Point(557, 325);
            cmbDrink.Margin = new Padding(2);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(164, 23);
            cmbDrink.TabIndex = 57;
            // 
            // cmbSalad
            // 
            cmbSalad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalad.FormattingEnabled = true;
            cmbSalad.Location = new Point(557, 257);
            cmbSalad.Margin = new Padding(2);
            cmbSalad.Name = "cmbSalad";
            cmbSalad.Size = new Size(164, 23);
            cmbSalad.TabIndex = 56;
            // 
            // cmbSaladSize
            // 
            cmbSaladSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaladSize.FormattingEnabled = true;
            cmbSaladSize.Location = new Point(557, 289);
            cmbSaladSize.Margin = new Padding(2);
            cmbSaladSize.Name = "cmbSaladSize";
            cmbSaladSize.Size = new Size(164, 23);
            cmbSaladSize.TabIndex = 55;
            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Location = new Point(557, 224);
            cmbPizzaSize.Margin = new Padding(2);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(164, 23);
            cmbPizzaSize.TabIndex = 54;
            // 
            // cmbPizzaFlavor
            // 
            cmbPizzaFlavor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPizzaFlavor.FormattingEnabled = true;
            cmbPizzaFlavor.Location = new Point(557, 194);
            cmbPizzaFlavor.Margin = new Padding(2);
            cmbPizzaFlavor.Name = "cmbPizzaFlavor";
            cmbPizzaFlavor.Size = new Size(164, 23);
            cmbPizzaFlavor.TabIndex = 53;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtTotal.Location = new Point(491, 427);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(159, 26);
            txtTotal.TabIndex = 51;
            // 
            // txtGovtTax
            // 
            txtGovtTax.BorderStyle = BorderStyle.None;
            txtGovtTax.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtGovtTax.Location = new Point(491, 392);
            txtGovtTax.Margin = new Padding(2);
            txtGovtTax.Name = "txtGovtTax";
            txtGovtTax.ReadOnly = true;
            txtGovtTax.Size = new Size(159, 26);
            txtGovtTax.TabIndex = 52;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(557, 166);
            txtPhoneNo.Margin = new Padding(2);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(164, 23);
            txtPhoneNo.TabIndex = 50;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(557, 131);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(164, 23);
            txtCustomerName.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(410, 426);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 48;
            label9.Text = "Total :";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label69.Location = new Point(377, 390);
            label69.Margin = new Padding(2, 0, 2, 0);
            label69.Name = "label69";
            label69.Size = new Size(96, 25);
            label69.TabIndex = 47;
            label69.Text = "Govt Tax :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 297);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 46;
            label4.Text = "Salad Size :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 333);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 45;
            label3.Text = "Drink";
            // 
            // txtdrink
            // 
            txtdrink.AutoSize = true;
            txtdrink.Location = new Point(358, 366);
            txtdrink.Margin = new Padding(2, 0, 2, 0);
            txtdrink.Name = "txtdrink";
            txtdrink.Size = new Size(84, 15);
            txtdrink.TabIndex = 44;
            txtdrink.Text = "Drink Volume :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 232);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 43;
            label5.Text = "Pizza Size : ";
            // 
            // txtsalad
            // 
            txtsalad.AutoSize = true;
            txtsalad.Location = new Point(358, 265);
            txtsalad.Margin = new Padding(2, 0, 2, 0);
            txtsalad.Name = "txtsalad";
            txtsalad.Size = new Size(35, 15);
            txtsalad.TabIndex = 42;
            txtsalad.Text = "Salad";
            // 
            // txtpizzaname
            // 
            txtpizzaname.AutoSize = true;
            txtpizzaname.Location = new Point(358, 202);
            txtpizzaname.Margin = new Padding(2, 0, 2, 0);
            txtpizzaname.Name = "txtpizzaname";
            txtpizzaname.Size = new Size(68, 15);
            txtpizzaname.TabIndex = 41;
            txtpizzaname.Text = "Pizza Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(358, 166);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(60, 15);
            lbl2.TabIndex = 40;
            lbl2.Text = "Phone No";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(358, 139);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 15);
            lbl1.TabIndex = 39;
            lbl1.Text = "Customer Name";
            // 
            // txtOrderid
            // 
            txtOrderid.Location = new Point(557, 94);
            txtOrderid.Margin = new Padding(2);
            txtOrderid.Name = "txtOrderid";
            txtOrderid.Size = new Size(164, 23);
            txtOrderid.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 39;
            label2.Text = "Order ID :";
            // 
            // btnSearchs
            // 
            btnSearchs.Location = new Point(742, 90);
            btnSearchs.Margin = new Padding(2);
            btnSearchs.Name = "btnSearchs";
            btnSearchs.Size = new Size(104, 28);
            btnSearchs.TabIndex = 60;
            btnSearchs.Text = "Search";
            btnSearchs.UseVisualStyleBackColor = true;
            btnSearchs.Click += btnSearchs_Click;
            // 
            // Updatecustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 492);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearchs);
            Controls.Add(btnexit);
            Controls.Add(cmbDrinkSize);
            Controls.Add(cmbDrink);
            Controls.Add(cmbSalad);
            Controls.Add(cmbSaladSize);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaFlavor);
            Controls.Add(txtTotal);
            Controls.Add(txtGovtTax);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtOrderid);
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
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Updatecustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Updatecustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnUpdate;
        private Button btnexit;
        private ComboBox cmbDrinkSize;
        private ComboBox cmbDrink;
        private ComboBox cmbSalad;
        private ComboBox cmbSaladSize;
        private ComboBox cmbPizzaSize;
        private ComboBox cmbPizzaFlavor;
        private TextBox txtTotal;
        private TextBox txtGovtTax;
        private TextBox txtPhoneNo;
        private TextBox txtCustomerName;
        private Label label9;
        private Label label69;
        private Label label4;
        private Label label3;
        private Label txtdrink;
        private Label label5;
        private Label txtsalad;
        private Label txtpizzaname;
        private Label lbl2;
        private Label lbl1;
        private TextBox txtOrderid;
        private Label label2;
        private Button btnSearchs;
    }
}