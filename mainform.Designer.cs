namespace StudendLogin
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_LogOut = new System.Windows.Forms.Button();
            this.main_addStudentBtn = new System.Windows.Forms.Button();
            this.main_dashboardbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.main_centerPanel = new System.Windows.Forms.Panel();
            this.dashboard1 = new StudendLogin.Dashboard();
            this.addStudents1 = new StudendLogin.addStudents();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.main_centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 101);
            this.panel1.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(145, 75);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(279, 23);
            this.header.TabIndex = 2;
            this.header.Text = "Student Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.main_LogOut);
            this.panel2.Controls.Add(this.main_addStudentBtn);
            this.panel2.Controls.Add(this.main_dashboardbtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.welcome_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 712);
            this.panel2.TabIndex = 1;
            // 
            // main_LogOut
            // 
            this.main_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_LogOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_LogOut.ForeColor = System.Drawing.Color.White;
            this.main_LogOut.Location = new System.Drawing.Point(41, 451);
            this.main_LogOut.Name = "main_LogOut";
            this.main_LogOut.Size = new System.Drawing.Size(83, 37);
            this.main_LogOut.TabIndex = 7;
            this.main_LogOut.Text = "Log out";
            this.main_LogOut.UseVisualStyleBackColor = true;
            this.main_LogOut.Click += new System.EventHandler(this.main_LogOut_Click);
            // 
            // main_addStudentBtn
            // 
            this.main_addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_addStudentBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.main_addStudentBtn.Location = new System.Drawing.Point(12, 233);
            this.main_addStudentBtn.Name = "main_addStudentBtn";
            this.main_addStudentBtn.Size = new System.Drawing.Size(138, 35);
            this.main_addStudentBtn.TabIndex = 5;
            this.main_addStudentBtn.Text = "Add Student";
            this.main_addStudentBtn.UseVisualStyleBackColor = true;
            this.main_addStudentBtn.Click += new System.EventHandler(this.main_addStudentBtn_Click);
            // 
            // main_dashboardbtn
            // 
            this.main_dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_dashboardbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.main_dashboardbtn.Location = new System.Drawing.Point(12, 176);
            this.main_dashboardbtn.Name = "main_dashboardbtn";
            this.main_dashboardbtn.Size = new System.Drawing.Size(138, 35);
            this.main_dashboardbtn.TabIndex = 4;
            this.main_dashboardbtn.Text = "Dashboard";
            this.main_dashboardbtn.UseVisualStyleBackColor = true;
            this.main_dashboardbtn.Click += new System.EventHandler(this.main_dashboardbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(24, 23);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(102, 19);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "Welcom User";
            // 
            // main_centerPanel
            // 
            this.main_centerPanel.Controls.Add(this.dashboard1);
            this.main_centerPanel.Controls.Add(this.addStudents1);
            this.main_centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_centerPanel.Location = new System.Drawing.Point(170, 101);
            this.main_centerPanel.Name = "main_centerPanel";
            this.main_centerPanel.Size = new System.Drawing.Size(945, 712);
            this.main_centerPanel.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.AutoSize = true;
            this.dashboard1.Location = new System.Drawing.Point(3, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(930, 621);
            this.dashboard1.TabIndex = 1;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // addStudents1
            // 
            this.addStudents1.Location = new System.Drawing.Point(0, 3);
            this.addStudents1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addStudents1.Name = "addStudents1";
            this.addStudents1.Size = new System.Drawing.Size(930, 499);
            this.addStudents1.TabIndex = 0;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 813);
            this.ControlBox = false;
            this.Controls.Add(this.main_centerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.main_centerPanel.ResumeLayout(false);
            this.main_centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button main_addStudentBtn;
        private System.Windows.Forms.Button main_dashboardbtn;
        private System.Windows.Forms.Button main_LogOut;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel main_centerPanel;
        private Dashboard dashboard1;
        private addStudents addStudents1;
    }
}