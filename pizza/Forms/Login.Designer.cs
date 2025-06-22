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
            label1 = new Label();
            label2 = new Label();
            txtpassword = new Label();
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(149, 104);
            txtpassword.Margin = new Padding(2, 0, 2, 0);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(57, 15);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(256, 65);
            txtusername.Margin = new Padding(2, 2, 2, 2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(166, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(256, 103);
            txtpass.Margin = new Padding(2, 2, 2, 2);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(166, 23);
            txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(256, 174);
            btnlogin.Margin = new Padding(2, 2, 2, 2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(78, 31);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(449, 236);
            btnexit.Margin = new Padding(2, 2, 2, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(78, 38);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(256, 137);
            chkShowPassword.Margin = new Padding(2, 2, 2, 2);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(164, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 285);
            Controls.Add(chkShowPassword);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txtpassword;
        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnexit;
        private CheckBox chkShowPassword;
    }
}