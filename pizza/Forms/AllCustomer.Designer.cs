namespace pizza.Forms
{
    partial class Deletecustomer
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
            label2 = new Label();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnFilter = new Button();
            btnRefresh = new Button();
            btnExportToExcel = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            lblTotalOrders = new Label();
            lblTotalSales = new Label();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Size = new Size(1151, 79);
            label1.TabIndex = 40;
            label1.Text = "Delivered Orders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 41;
            label2.Text = "From Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(21, 136);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 41;
            label3.Text = "To Date :";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(121, 98);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShowCheckBox = true;
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 42;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(121, 136);
            dtpTo.Name = "dtpTo";
            dtpTo.ShowCheckBox = true;
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 42;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(533, 112);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(86, 28);
            btnFilter.TabIndex = 43;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(441, 112);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 28);
            btnRefresh.TabIndex = 43;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(349, 112);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(86, 28);
            btnExportToExcel.TabIndex = 43;
            btnExportToExcel.Text = "Export";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1058, 494);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 28);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1127, 260);
            dataGridView1.TabIndex = 44;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalOrders.Location = new Point(126, 456);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(30, 21);
            lblTotalOrders.TabIndex = 41;
            lblTotalOrders.Text = "XX";
            lblTotalOrders.Click += lblTotalOrders_Click;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalSales.Location = new Point(126, 490);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(73, 21);
            lblTotalSales.TabIndex = 41;
            lblTotalSales.Text = "PKR XXX";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(625, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 28);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(13, 456);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 41;
            label4.Text = "Total Orders :";
            label4.Click += lblTotalOrders_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 490);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 41;
            label5.Text = "Total Sales :";
            // 
            // Deletecustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 529);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(label5);
            Controls.Add(lblTotalSales);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblTotalOrders);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Deletecustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deletecustomer";
            Load += Deletecustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnFilter;
        private Button btnRefresh;
        private Button btnExportToExcel;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Label lblTotalOrders;
        private Label lblTotalSales;
        private Button btnDelete;
        private Label label4;
        private Label label5;
    }
}