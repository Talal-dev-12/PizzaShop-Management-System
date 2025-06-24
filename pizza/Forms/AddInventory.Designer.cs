namespace pizza.Forms
{
    partial class AddInventory
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
            cmbPizzaFlavor = new ComboBox();
            cmbPizzaSize = new ComboBox();
            btnUpdatePizzaStock = new Button();
            btnDeletePizzaStock = new Button();
            btnAddPizzaStock = new Button();
            gridPizzaInventory = new DataGridView();
            txtPizzaQty = new TextBox();
            txtDrinkQty = new TextBox();
            gridDrinkInventory = new DataGridView();
            btnAddDrinkStock = new Button();
            btnDeleteDrinkStock = new Button();
            btnUpdateDrinkStock = new Button();
            cmbDrinkSize = new ComboBox();
            cmbDrinkItem = new ComboBox();
            txtSaladQty = new TextBox();
            gridSaladInventory = new DataGridView();
            btnAddSaladStock = new Button();
            btnDeleteSaladStock = new Button();
            btnUpdateSaladStock = new Button();
            cmbSaladSize = new ComboBox();
            cmbSaladItem = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPizzaInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDrinkInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSaladInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1939, 169);
            label1.TabIndex = 1;
            label1.Text = "ADD INVENTORY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPizzaFlavor
            // 
            cmbPizzaFlavor.FormattingEnabled = true;
            cmbPizzaFlavor.Location = new Point(36, 343);
            cmbPizzaFlavor.Name = "cmbPizzaFlavor";
            cmbPizzaFlavor.Size = new Size(242, 40);
            cmbPizzaFlavor.TabIndex = 2;
            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Location = new Point(36, 400);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(242, 40);
            cmbPizzaSize.TabIndex = 3;
            // 
            // btnUpdatePizzaStock
            // 
            btnUpdatePizzaStock.Location = new Point(187, 595);
            btnUpdatePizzaStock.Name = "btnUpdatePizzaStock";
            btnUpdatePizzaStock.Size = new Size(150, 46);
            btnUpdatePizzaStock.TabIndex = 4;
            btnUpdatePizzaStock.Text = "Update";
            btnUpdatePizzaStock.UseVisualStyleBackColor = true;
            // 
            // btnDeletePizzaStock
            // 
            btnDeletePizzaStock.Location = new Point(351, 595);
            btnDeletePizzaStock.Name = "btnDeletePizzaStock";
            btnDeletePizzaStock.Size = new Size(150, 46);
            btnDeletePizzaStock.TabIndex = 5;
            btnDeletePizzaStock.Text = "Delete";
            btnDeletePizzaStock.UseVisualStyleBackColor = true;
            // 
            // btnAddPizzaStock
            // 
            btnAddPizzaStock.Location = new Point(26, 595);
            btnAddPizzaStock.Name = "btnAddPizzaStock";
            btnAddPizzaStock.Size = new Size(150, 46);
            btnAddPizzaStock.TabIndex = 6;
            btnAddPizzaStock.Text = "Add";
            btnAddPizzaStock.UseVisualStyleBackColor = true;
            // 
            // gridPizzaInventory
            // 
            gridPizzaInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPizzaInventory.Location = new Point(26, 647);
            gridPizzaInventory.Name = "gridPizzaInventory";
            gridPizzaInventory.RowHeadersWidth = 82;
            gridPizzaInventory.Size = new Size(480, 300);
            gridPizzaInventory.TabIndex = 7;
            // 
            // txtPizzaQty
            // 
            txtPizzaQty.Location = new Point(36, 287);
            txtPizzaQty.Name = "txtPizzaQty";
            txtPizzaQty.Size = new Size(242, 39);
            txtPizzaQty.TabIndex = 8;
            // 
            // txtDrinkQty
            // 
            txtDrinkQty.Location = new Point(711, 287);
            txtDrinkQty.Name = "txtDrinkQty";
            txtDrinkQty.Size = new Size(242, 39);
            txtDrinkQty.TabIndex = 15;
            // 
            // gridDrinkInventory
            // 
            gridDrinkInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDrinkInventory.Location = new Point(701, 647);
            gridDrinkInventory.Name = "gridDrinkInventory";
            gridDrinkInventory.RowHeadersWidth = 82;
            gridDrinkInventory.Size = new Size(480, 300);
            gridDrinkInventory.TabIndex = 14;
            // 
            // btnAddDrinkStock
            // 
            btnAddDrinkStock.Location = new Point(701, 595);
            btnAddDrinkStock.Name = "btnAddDrinkStock";
            btnAddDrinkStock.Size = new Size(150, 46);
            btnAddDrinkStock.TabIndex = 13;
            btnAddDrinkStock.Text = "button4";
            btnAddDrinkStock.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrinkStock
            // 
            btnDeleteDrinkStock.Location = new Point(1026, 595);
            btnDeleteDrinkStock.Name = "btnDeleteDrinkStock";
            btnDeleteDrinkStock.Size = new Size(150, 46);
            btnDeleteDrinkStock.TabIndex = 12;
            btnDeleteDrinkStock.Text = "button5";
            btnDeleteDrinkStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDrinkStock
            // 
            btnUpdateDrinkStock.Location = new Point(870, 595);
            btnUpdateDrinkStock.Name = "btnUpdateDrinkStock";
            btnUpdateDrinkStock.Size = new Size(150, 46);
            btnUpdateDrinkStock.TabIndex = 11;
            btnUpdateDrinkStock.Text = "button6";
            btnUpdateDrinkStock.UseVisualStyleBackColor = true;
            // 
            // cmbDrinkSize
            // 
            cmbDrinkSize.FormattingEnabled = true;
            cmbDrinkSize.Location = new Point(711, 400);
            cmbDrinkSize.Name = "cmbDrinkSize";
            cmbDrinkSize.Size = new Size(242, 40);
            cmbDrinkSize.TabIndex = 10;
            // 
            // cmbDrinkItem
            // 
            cmbDrinkItem.FormattingEnabled = true;
            cmbDrinkItem.Location = new Point(711, 343);
            cmbDrinkItem.Name = "cmbDrinkItem";
            cmbDrinkItem.Size = new Size(242, 40);
            cmbDrinkItem.TabIndex = 9;
            // 
            // txtSaladQty
            // 
            txtSaladQty.Location = new Point(1418, 287);
            txtSaladQty.Name = "txtSaladQty";
            txtSaladQty.Size = new Size(242, 39);
            txtSaladQty.TabIndex = 22;
            // 
            // gridSaladInventory
            // 
            gridSaladInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSaladInventory.Location = new Point(1408, 647);
            gridSaladInventory.Name = "gridSaladInventory";
            gridSaladInventory.RowHeadersWidth = 82;
            gridSaladInventory.Size = new Size(480, 300);
            gridSaladInventory.TabIndex = 21;
            // 
            // btnAddSaladStock
            // 
            btnAddSaladStock.Location = new Point(1408, 595);
            btnAddSaladStock.Name = "btnAddSaladStock";
            btnAddSaladStock.Size = new Size(150, 46);
            btnAddSaladStock.TabIndex = 20;
            btnAddSaladStock.Text = "button7";
            btnAddSaladStock.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSaladStock
            // 
            btnDeleteSaladStock.Location = new Point(1733, 595);
            btnDeleteSaladStock.Name = "btnDeleteSaladStock";
            btnDeleteSaladStock.Size = new Size(150, 46);
            btnDeleteSaladStock.TabIndex = 19;
            btnDeleteSaladStock.Text = "button8";
            btnDeleteSaladStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSaladStock
            // 
            btnUpdateSaladStock.Location = new Point(1577, 595);
            btnUpdateSaladStock.Name = "btnUpdateSaladStock";
            btnUpdateSaladStock.Size = new Size(150, 46);
            btnUpdateSaladStock.TabIndex = 18;
            btnUpdateSaladStock.Text = "button9";
            btnUpdateSaladStock.UseVisualStyleBackColor = true;
            // 
            // cmbSaladSize
            // 
            cmbSaladSize.FormattingEnabled = true;
            cmbSaladSize.Location = new Point(1418, 400);
            cmbSaladSize.Name = "cmbSaladSize";
            cmbSaladSize.Size = new Size(242, 40);
            cmbSaladSize.TabIndex = 17;
            // 
            // cmbSaladItem
            // 
            cmbSaladItem.FormattingEnabled = true;
            cmbSaladItem.Location = new Point(1418, 343);
            cmbSaladItem.Name = "cmbSaladItem";
            cmbSaladItem.Size = new Size(242, 40);
            cmbSaladItem.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(96, 194);
            label2.Name = "label2";
            label2.Size = new Size(182, 45);
            label2.TabIndex = 23;
            label2.Text = "Pizza Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(766, 194);
            label3.Name = "label3";
            label3.Size = new Size(187, 45);
            label3.TabIndex = 23;
            label3.Text = "Drink Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(1474, 194);
            label4.Name = "label4";
            label4.Size = new Size(186, 45);
            label4.TabIndex = 23;
            label4.Text = "Salad Stock";
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1939, 966);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSaladQty);
            Controls.Add(gridSaladInventory);
            Controls.Add(btnAddSaladStock);
            Controls.Add(btnDeleteSaladStock);
            Controls.Add(btnUpdateSaladStock);
            Controls.Add(cmbSaladSize);
            Controls.Add(cmbSaladItem);
            Controls.Add(txtDrinkQty);
            Controls.Add(gridDrinkInventory);
            Controls.Add(btnAddDrinkStock);
            Controls.Add(btnDeleteDrinkStock);
            Controls.Add(btnUpdateDrinkStock);
            Controls.Add(cmbDrinkSize);
            Controls.Add(cmbDrinkItem);
            Controls.Add(txtPizzaQty);
            Controls.Add(gridPizzaInventory);
            Controls.Add(btnAddPizzaStock);
            Controls.Add(btnDeletePizzaStock);
            Controls.Add(btnUpdatePizzaStock);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaFlavor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "AddInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventory";
            ((System.ComponentModel.ISupportInitialize)gridPizzaInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDrinkInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSaladInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPizzaFlavor;
        private ComboBox cmbPizzaSize;
        private Button btnUpdatePizzaStock;
        private Button btnDeletePizzaStock;
        private Button btnAddPizzaStock;
        private DataGridView gridPizzaInventory;
        private TextBox txtPizzaQty;
        private TextBox txtDrinkQty;
        private DataGridView gridDrinkInventory;
        private Button btnAddDrinkStock;
        private Button btnDeleteDrinkStock;
        private Button btnUpdateDrinkStock;
        private ComboBox cmbDrinkSize;
        private ComboBox cmbDrinkItem;
        private TextBox txtSaladQty;
        private DataGridView gridSaladInventory;
        private Button btnAddSaladStock;
        private Button btnDeleteSaladStock;
        private Button btnUpdateSaladStock;
        private ComboBox cmbSaladSize;
        private ComboBox cmbSaladItem;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}