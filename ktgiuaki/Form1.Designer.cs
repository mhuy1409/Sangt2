namespace ktgiuaki
{
    partial class textlogin
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
            this.Username = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(159, 130);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(92, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "tên đăng nhập";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // textboxusername
            // 
<<<<<<< HEAD
            this.textboxusername.Location = new System.Drawing.Point(248, 36);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(161, 22);
            this.textboxusername.TabIndex = 1;
=======
            this.txtUsername.Location = new System.Drawing.Point(294, 130);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 1;
>>>>>>> d076de9a636e48af310b1ccaf90157063ebe0fb5
            // 
            // textboxmatkhau
            // 
<<<<<<< HEAD
            this.textboxmatkhau.Location = new System.Drawing.Point(248, 94);
            this.textboxmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(161, 22);
            this.textboxmatkhau.TabIndex = 2;
=======
            this.txtpassword.Location = new System.Drawing.Point(294, 181);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(200, 22);
            this.txtpassword.TabIndex = 2;
>>>>>>> d076de9a636e48af310b1ccaf90157063ebe0fb5
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "mật khẩu";
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(248, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 42);
=======
            this.button1.Location = new System.Drawing.Point(294, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
>>>>>>> d076de9a636e48af310b1ccaf90157063ebe0fb5
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "textlogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.TextBox textboxmatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

