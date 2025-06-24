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
            btnDisplayInventory = new Button();
            btnInventory = new Button();
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
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1044, 68);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.Location = new Point(11, 16);
            btnaddcustomer.Margin = new Padding(2);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(135, 26);
            btnaddcustomer.TabIndex = 2;
            btnaddcustomer.Text = "Add Customer";
            btnaddcustomer.UseVisualStyleBackColor = true;
            btnaddcustomer.Click += btnaddcustomer_Click;
            // 
            // btnupdatecustomer
            // 
            btnupdatecustomer.Location = new Point(11, 46);
            btnupdatecustomer.Margin = new Padding(2);
            btnupdatecustomer.Name = "btnupdatecustomer";
            btnupdatecustomer.Size = new Size(135, 26);
            btnupdatecustomer.TabIndex = 3;
            btnupdatecustomer.Text = "Update Customer";
            btnupdatecustomer.UseVisualStyleBackColor = true;
            btnupdatecustomer.Click += btnupdatecustomer_Click;
            // 
            // btndeletecustomer
            // 
            btndeletecustomer.Location = new Point(11, 106);
            btndeletecustomer.Margin = new Padding(2);
            btndeletecustomer.Name = "btndeletecustomer";
            btndeletecustomer.Size = new Size(135, 26);
            btndeletecustomer.TabIndex = 4;
            btndeletecustomer.Text = "All Customer";
            btndeletecustomer.UseVisualStyleBackColor = true;
            btndeletecustomer.Click += btndeletecustomer_Click;
            // 
            // btndisplaydata
            // 
            btndisplaydata.Location = new Point(11, 76);
            btndisplaydata.Margin = new Padding(2);
            btndisplaydata.Name = "btndisplaydata";
            btndisplaydata.Size = new Size(135, 26);
            btndisplaydata.TabIndex = 6;
            btndisplaydata.Text = "Active Customer";
            btndisplaydata.UseVisualStyleBackColor = true;
            btndisplaydata.Click += btndisplaydata_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(11, 348);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(135, 26);
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
            panel1.Controls.Add(btnDisplayInventory);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btndisplaydata);
            panel1.Controls.Add(btnupdatecustomer);
            panel1.Controls.Add(btndeletecustomer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 385);
            panel1.TabIndex = 9;
            // 
            // btnDisplayInventory
            // 
            btnDisplayInventory.Location = new Point(11, 271);
            btnDisplayInventory.Margin = new Padding(2);
            btnDisplayInventory.Name = "btnDisplayInventory";
            btnDisplayInventory.Size = new Size(135, 26);
            btnDisplayInventory.TabIndex = 6;
            btnDisplayInventory.Text = "DISPLAY INVENTORY";
            btnDisplayInventory.UseVisualStyleBackColor = true;
            btnDisplayInventory.Click += btndisplaydata_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(11, 241);
            btnInventory.Margin = new Padding(2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(135, 26);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "ADD INVENTORY";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btndisplaydata_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(875, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 453);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private Button btnDisplayInventory;
        private Button btnInventory;
    }
}