namespace pizza.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            btnaddcustomer = new Button();
            btnupdatecustomer = new Button();
            btndeletecustomer = new Button();
            btndisplaydata = new Button();
            btnexit = new Button();
            panel1 = new Panel();
            BtnInventory = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1939, 145);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.Location = new Point(20, 34);
            btnaddcustomer.Margin = new Padding(4);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(251, 55);
            btnaddcustomer.TabIndex = 2;
            btnaddcustomer.Text = "Add Customer";
            btnaddcustomer.UseVisualStyleBackColor = true;
            btnaddcustomer.Click += btnaddcustomer_Click;
            // 
            // btnupdatecustomer
            // 
            btnupdatecustomer.Location = new Point(20, 98);
            btnupdatecustomer.Margin = new Padding(4);
            btnupdatecustomer.Name = "btnupdatecustomer";
            btnupdatecustomer.Size = new Size(251, 55);
            btnupdatecustomer.TabIndex = 3;
            btnupdatecustomer.Text = "Update Customer";
            btnupdatecustomer.UseVisualStyleBackColor = true;
            btnupdatecustomer.Click += btnupdatecustomer_Click;
            // 
            // btndeletecustomer
            // 
            btndeletecustomer.Location = new Point(20, 226);
            btndeletecustomer.Margin = new Padding(4);
            btndeletecustomer.Name = "btndeletecustomer";
            btndeletecustomer.Size = new Size(251, 55);
            btndeletecustomer.TabIndex = 4;
            btndeletecustomer.Text = "All Customer Data";
            btndeletecustomer.UseVisualStyleBackColor = true;
            btndeletecustomer.Click += btndeletecustomer_Click;
            // 
            // btndisplaydata
            // 
            btndisplaydata.Location = new Point(20, 162);
            btndisplaydata.Margin = new Padding(4);
            btndisplaydata.Name = "btndisplaydata";
            btndisplaydata.Size = new Size(251, 55);
            btndisplaydata.TabIndex = 6;
            btndisplaydata.Text = "Active Customer";
            btndisplaydata.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(20, 742);
            btnexit.Margin = new Padding(4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(251, 55);
            btnexit.TabIndex = 8;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(btnaddcustomer);
            panel1.Controls.Add(BtnInventory);
            panel1.Controls.Add(btndisplaydata);
            panel1.Controls.Add(btnupdatecustomer);
            panel1.Controls.Add(btndeletecustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 145);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 821);
            panel1.TabIndex = 9;
            // 
            // BtnInventory
            // 
            BtnInventory.Location = new Point(20, 289);
            BtnInventory.Margin = new Padding(4);
            BtnInventory.Name = "BtnInventory";
            BtnInventory.Size = new Size(251, 55);
            BtnInventory.TabIndex = 6;
            BtnInventory.Text = "ADD INVENTORY";
            BtnInventory.UseVisualStyleBackColor = true;
            BtnInventory.Click += BtnInventory_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(314, 145);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1625, 821);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1939, 966);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnaddcustomer;
        private Button btnupdatecustomer;
        private Button btndeletecustomer;
        private Button btndisplaydata;
        private Button btnexit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnInventory;
    }
}