namespace pizza.Forms
{
    partial class ActiveOrders
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
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            rdoPreparing = new RadioButton();
            rdoReady = new RadioButton();
            rdoDelivered = new RadioButton();
            btnStatus = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 145);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1022, 297);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(923, 456);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1044, 79);
            label1.TabIndex = 39;
            label1.Text = "Active Customers Orders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(12, 97);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter ID or Name";
            txtSearch.Size = new Size(168, 27);
            txtSearch.TabIndex = 40;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(195, 97);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // rdoPreparing
            // 
            rdoPreparing.AutoSize = true;
            rdoPreparing.Location = new Point(11, 467);
            rdoPreparing.Name = "rdoPreparing";
            rdoPreparing.Size = new Size(76, 19);
            rdoPreparing.TabIndex = 41;
            rdoPreparing.TabStop = true;
            rdoPreparing.Text = "Preparing";
            rdoPreparing.UseVisualStyleBackColor = true;
            // 
            // rdoReady
            // 
            rdoReady.AutoSize = true;
            rdoReady.Location = new Point(93, 468);
            rdoReady.Name = "rdoReady";
            rdoReady.Size = new Size(57, 19);
            rdoReady.TabIndex = 41;
            rdoReady.TabStop = true;
            rdoReady.Text = "Ready";
            rdoReady.UseVisualStyleBackColor = true;
            // 
            // rdoDelivered
            // 
            rdoDelivered.AutoSize = true;
            rdoDelivered.Location = new Point(156, 467);
            rdoDelivered.Name = "rdoDelivered";
            rdoDelivered.Size = new Size(74, 19);
            rdoDelivered.TabIndex = 41;
            rdoDelivered.TabStop = true;
            rdoDelivered.Text = "Delivered";
            rdoDelivered.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(245, 458);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(109, 37);
            btnStatus.TabIndex = 42;
            btnStatus.Text = "Update Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(372, 458);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 37);
            btnRefresh.TabIndex = 42;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // ActiveOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 503);
            Controls.Add(btnRefresh);
            Controls.Add(btnStatus);
            Controls.Add(rdoDelivered);
            Controls.Add(rdoReady);
            Controls.Add(rdoPreparing);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ActiveOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "displaydata";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnClose;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private RadioButton rdoPreparing;
        private RadioButton rdoReady;
        private RadioButton rdoDelivered;
        private Button btnStatus;
        private Button btnRefresh;
    }
}