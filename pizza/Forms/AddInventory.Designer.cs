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
            cmbDrinkName = new ComboBox();
            txtSaladQty = new TextBox();
            gridSaladInventory = new DataGridView();
            btnAddSaladStock = new Button();
            btnDeleteSaladStock = new Button();
            btnUpdateSaladStock = new Button();
            cmbSaladSize = new ComboBox();
            cmbSaladName = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            BtnClose = new Button();
            label5 = new Label();
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
            label1.Size = new Size(2315, 160);
            label1.TabIndex = 1;
            label1.Text = "ADD INVENTORY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbPizzaFlavor
            // 
            cmbPizzaFlavor.FormattingEnabled = true;
            cmbPizzaFlavor.Location = new Point(169, 459);
            cmbPizzaFlavor.Name = "cmbPizzaFlavor";
            cmbPizzaFlavor.Size = new Size(370, 40);
            cmbPizzaFlavor.TabIndex = 2;
            // 
            // cmbPizzaSize
            // 
            cmbPizzaSize.FormattingEnabled = true;
            cmbPizzaSize.Location = new Point(169, 516);
            cmbPizzaSize.Name = "cmbPizzaSize";
            cmbPizzaSize.Size = new Size(370, 40);
            cmbPizzaSize.TabIndex = 3;
            // 
            // btnUpdatePizzaStock
            // 
            btnUpdatePizzaStock.Location = new Point(266, 595);
            btnUpdatePizzaStock.Name = "btnUpdatePizzaStock";
            btnUpdatePizzaStock.Size = new Size(150, 46);
            btnUpdatePizzaStock.TabIndex = 4;
            btnUpdatePizzaStock.Text = "Update";
            btnUpdatePizzaStock.UseVisualStyleBackColor = true;
            // 
            // btnDeletePizzaStock
            // 
            btnDeletePizzaStock.Location = new Point(504, 595);
            btnDeletePizzaStock.Name = "btnDeletePizzaStock";
            btnDeletePizzaStock.Size = new Size(150, 46);
            btnDeletePizzaStock.TabIndex = 5;
            btnDeletePizzaStock.Text = "Delete";
            btnDeletePizzaStock.UseVisualStyleBackColor = true;
            // 
            // btnAddPizzaStock
            // 
            btnAddPizzaStock.Location = new Point(36, 595);
            btnAddPizzaStock.Name = "btnAddPizzaStock";
            btnAddPizzaStock.Size = new Size(150, 46);
            btnAddPizzaStock.TabIndex = 6;
            btnAddPizzaStock.Text = "Add";
            btnAddPizzaStock.UseVisualStyleBackColor = true;
            // 
            // gridPizzaInventory
            // 
            gridPizzaInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPizzaInventory.Location = new Point(12, 647);
            gridPizzaInventory.Name = "gridPizzaInventory";
            gridPizzaInventory.RowHeadersWidth = 82;
            gridPizzaInventory.Size = new Size(685, 483);
            gridPizzaInventory.TabIndex = 7;
            // 
            // txtPizzaQty
            // 
            txtPizzaQty.Location = new Point(169, 403);
            txtPizzaQty.Name = "txtPizzaQty";
            txtPizzaQty.Size = new Size(370, 39);
            txtPizzaQty.TabIndex = 8;
            // 
            // txtDrinkQty
            // 
            txtDrinkQty.Location = new Point(921, 382);
            txtDrinkQty.Name = "txtDrinkQty";
            txtDrinkQty.Size = new Size(387, 39);
            txtDrinkQty.TabIndex = 15;
            // 
            // gridDrinkInventory
            // 
            gridDrinkInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDrinkInventory.Location = new Point(760, 647);
            gridDrinkInventory.Name = "gridDrinkInventory";
            gridDrinkInventory.RowHeadersWidth = 82;
            gridDrinkInventory.Size = new Size(685, 483);
            gridDrinkInventory.TabIndex = 14;
            // 
            // btnAddDrinkStock
            // 
            btnAddDrinkStock.Location = new Point(796, 595);
            btnAddDrinkStock.Name = "btnAddDrinkStock";
            btnAddDrinkStock.Size = new Size(150, 46);
            btnAddDrinkStock.TabIndex = 13;
            btnAddDrinkStock.Text = "Add";
            btnAddDrinkStock.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrinkStock
            // 
            btnDeleteDrinkStock.Location = new Point(1264, 595);
            btnDeleteDrinkStock.Name = "btnDeleteDrinkStock";
            btnDeleteDrinkStock.Size = new Size(150, 46);
            btnDeleteDrinkStock.TabIndex = 12;
            btnDeleteDrinkStock.Text = "Delete";
            btnDeleteDrinkStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDrinkStock
            // 
            btnUpdateDrinkStock.Location = new Point(1035, 595);
            btnUpdateDrinkStock.Name = "btnUpdateDrinkStock";
            btnUpdateDrinkStock.Size = new Size(150, 46);
            btnUpdateDrinkStock.TabIndex = 11;
            btnUpdateDrinkStock.Text = "Update";
            btnUpdateDrinkStock.UseVisualStyleBackColor = true;
            // 
            // cmbDrinkSize
            // 
            cmbDrinkSize.FormattingEnabled = true;
            cmbDrinkSize.Location = new Point(921, 495);
            cmbDrinkSize.Name = "cmbDrinkSize";
            cmbDrinkSize.Size = new Size(387, 40);
            cmbDrinkSize.TabIndex = 10;
            // 
            // cmbDrinkName
            // 
            cmbDrinkName.FormattingEnabled = true;
            cmbDrinkName.Location = new Point(921, 438);
            cmbDrinkName.Name = "cmbDrinkName";
            cmbDrinkName.Size = new Size(387, 40);
            cmbDrinkName.TabIndex = 9;
            // 
            // txtSaladQty
            // 
            txtSaladQty.Location = new Point(1745, 393);
            txtSaladQty.Name = "txtSaladQty";
            txtSaladQty.Size = new Size(383, 39);
            txtSaladQty.TabIndex = 22;
            // 
            // gridSaladInventory
            // 
            gridSaladInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSaladInventory.Location = new Point(1618, 647);
            gridSaladInventory.Name = "gridSaladInventory";
            gridSaladInventory.RowHeadersWidth = 82;
            gridSaladInventory.Size = new Size(685, 483);
            gridSaladInventory.TabIndex = 21;
            // 
            // btnAddSaladStock
            // 
            btnAddSaladStock.Location = new Point(1653, 595);
            btnAddSaladStock.Name = "btnAddSaladStock";
            btnAddSaladStock.Size = new Size(150, 46);
            btnAddSaladStock.TabIndex = 20;
            btnAddSaladStock.Text = "Add";
            btnAddSaladStock.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSaladStock
            // 
            btnDeleteSaladStock.Location = new Point(2121, 595);
            btnDeleteSaladStock.Name = "btnDeleteSaladStock";
            btnDeleteSaladStock.Size = new Size(150, 46);
            btnDeleteSaladStock.TabIndex = 19;
            btnDeleteSaladStock.Text = "Delete";
            btnDeleteSaladStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSaladStock
            // 
            btnUpdateSaladStock.Location = new Point(1900, 595);
            btnUpdateSaladStock.Name = "btnUpdateSaladStock";
            btnUpdateSaladStock.Size = new Size(150, 46);
            btnUpdateSaladStock.TabIndex = 18;
            btnUpdateSaladStock.Text = "Update";
            btnUpdateSaladStock.UseVisualStyleBackColor = true;
            // 
            // cmbSaladSize
            // 
            cmbSaladSize.FormattingEnabled = true;
            cmbSaladSize.Location = new Point(1745, 495);
            cmbSaladSize.Name = "cmbSaladSize";
            cmbSaladSize.Size = new Size(383, 40);
            cmbSaladSize.TabIndex = 17;
            // 
            // cmbSaladName
            // 
            cmbSaladName.FormattingEnabled = true;
            cmbSaladName.Location = new Point(1745, 438);
            cmbSaladName.Name = "cmbSaladName";
            cmbSaladName.Size = new Size(383, 40);
            cmbSaladName.TabIndex = 16;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(778, 295);
            label3.Name = "label3";
            label3.Size = new Size(685, 45);
            label3.TabIndex = 23;
            label3.Text = "Drink Stock";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(1616, 283);
            label4.Name = "label4";
            label4.Size = new Size(685, 45);
            label4.TabIndex = 23;
            label4.Text = "Salad Stock";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.ActiveBorder;
            BtnClose.BackgroundImageLayout = ImageLayout.None;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClose.Location = new Point(2255, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(60, 69);
            BtnClose.TabIndex = 25;
            BtnClose.Text = "X";
            BtnClose.TextAlign = ContentAlignment.TopRight;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(13, 328);
            label5.Name = "label5";
            label5.Size = new Size(685, 45);
            label5.TabIndex = 23;
            label5.Text = "Pizza Stock";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2315, 1142);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtSaladQty);
            Controls.Add(gridSaladInventory);
            Controls.Add(btnAddSaladStock);
            Controls.Add(btnDeleteSaladStock);
            Controls.Add(btnUpdateSaladStock);
            Controls.Add(cmbSaladSize);
            Controls.Add(cmbSaladName);
            Controls.Add(txtDrinkQty);
            Controls.Add(gridDrinkInventory);
            Controls.Add(btnAddDrinkStock);
            Controls.Add(btnDeleteDrinkStock);
            Controls.Add(btnUpdateDrinkStock);
            Controls.Add(cmbDrinkSize);
            Controls.Add(cmbDrinkName);
            Controls.Add(txtPizzaQty);
            Controls.Add(gridPizzaInventory);
            Controls.Add(btnAddPizzaStock);
            Controls.Add(btnDeletePizzaStock);
            Controls.Add(btnUpdatePizzaStock);
            Controls.Add(cmbPizzaSize);
            Controls.Add(cmbPizzaFlavor);
            Controls.Add(BtnClose);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "AddInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventory";
            Load += AddInventory_Load;
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
        private ComboBox cmbDrinkName;
        private TextBox txtSaladQty;
        private DataGridView gridSaladInventory;
        private Button btnAddSaladStock;
        private Button btnDeleteSaladStock;
        private Button btnUpdateSaladStock;
        private ComboBox cmbSaladSize;
        private ComboBox cmbSaladName;
        private Label label3;
        private Label label4;
        private Button BtnClose;
        private Label label5;
    }
}