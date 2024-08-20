namespace StudendLogin
{
    partial class signIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            this.userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signIn_username = new System.Windows.Forms.TextBox();
            this.signIn_password = new System.Windows.Forms.TextBox();
            this.SignIn_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.closeAppBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(45, 150);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(87, 19);
            this.userName.TabIndex = 0;
            this.userName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sign In";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signIn_username
            // 
            this.signIn_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_username.Location = new System.Drawing.Point(49, 177);
            this.signIn_username.Margin = new System.Windows.Forms.Padding(2);
            this.signIn_username.Name = "signIn_username";
            this.signIn_username.Size = new System.Drawing.Size(221, 27);
            this.signIn_username.TabIndex = 4;
            // 
            // signIn_password
            // 
            this.signIn_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_password.Location = new System.Drawing.Point(49, 257);
            this.signIn_password.Margin = new System.Windows.Forms.Padding(2);
            this.signIn_password.Name = "signIn_password";
            this.signIn_password.PasswordChar = '*';
            this.signIn_password.Size = new System.Drawing.Size(221, 27);
            this.signIn_password.TabIndex = 5;
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.BackColor = System.Drawing.Color.Azure;
            this.SignIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn_btn.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SignIn_btn.Location = new System.Drawing.Point(49, 296);
            this.SignIn_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Size = new System.Drawing.Size(63, 28);
            this.SignIn_btn.TabIndex = 6;
            this.SignIn_btn.Text = "Sign In";
            this.SignIn_btn.UseVisualStyleBackColor = false;
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.Azure;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(49, 406);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(69, 29);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.closeAppBtn.Location = new System.Drawing.Point(332, 6);
            this.closeAppBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(21, 22);
            this.closeAppBtn.TabIndex = 8;
            this.closeAppBtn.Text = "X";
            this.closeAppBtn.UseVisualStyleBackColor = false;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // signIn
            // 
            this.AcceptButton = this.SignIn_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(362, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.SignIn_btn);
            this.Controls.Add(this.signIn_password);
            this.Controls.Add(this.signIn_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.signIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signIn_username;
        private System.Windows.Forms.TextBox signIn_password;
        private System.Windows.Forms.Button SignIn_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button closeAppBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

