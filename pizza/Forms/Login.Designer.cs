using System.Windows.Forms;

namespace pizza
{
    partial class Login
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
            label2 = new Label();
            txtpassword = new Label();
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(130, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(131, 137);
            txtpassword.Margin = new Padding(2, 0, 2, 0);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(83, 21);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Password :";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(232, 100);
            txtusername.Margin = new Padding(2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(166, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(232, 138);
            txtpass.Margin = new Padding(2);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(166, 23);
            txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(245, 193);
            btnlogin.Margin = new Padding(2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(97, 31);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(479, 276);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(66, 27);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.Blue;
            chkShowPassword.Location = new Point(289, 165);
            chkShowPassword.Margin = new Padding(2);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(109, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(556, 65);
            label3.TabIndex = 39;
            label3.Text = "LOGIN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 314);
            Controls.Add(label3);
            Controls.Add(chkShowPassword);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label txtpassword;
        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnexit;
        private CheckBox chkShowPassword;
        private Label label3;
    }
}