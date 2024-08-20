namespace StudendLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboard_dropout = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard_graduates = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard_enrollled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 165);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Controls.Add(this.dashboard_dropout);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(681, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 142);
            this.panel5.TabIndex = 2;
            // 
            // dashboard_dropout
            // 
            this.dashboard_dropout.AutoSize = true;
            this.dashboard_dropout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_dropout.Location = new System.Drawing.Point(154, 110);
            this.dashboard_dropout.Name = "dashboard_dropout";
            this.dashboard_dropout.Size = new System.Drawing.Size(20, 23);
            this.dashboard_dropout.TabIndex = 2;
            this.dashboard_dropout.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Students Drop Out";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.dashboard_graduates);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(354, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 142);
            this.panel3.TabIndex = 1;
            // 
            // dashboard_graduates
            // 
            this.dashboard_graduates.AutoSize = true;
            this.dashboard_graduates.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_graduates.Location = new System.Drawing.Point(161, 110);
            this.dashboard_graduates.Name = "dashboard_graduates";
            this.dashboard_graduates.Size = new System.Drawing.Size(20, 23);
            this.dashboard_graduates.TabIndex = 2;
            this.dashboard_graduates.Text = "0";
            this.dashboard_graduates.Click += new System.EventHandler(this.dashboard_graduates_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Students Graduated";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.dashboard_enrollled);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 142);
            this.panel2.TabIndex = 0;
            // 
            // dashboard_enrollled
            // 
            this.dashboard_enrollled.AutoSize = true;
            this.dashboard_enrollled.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_enrollled.Location = new System.Drawing.Point(163, 110);
            this.dashboard_enrollled.Name = "dashboard_enrollled";
            this.dashboard_enrollled.Size = new System.Drawing.Size(20, 23);
            this.dashboard_enrollled.TabIndex = 1;
            this.dashboard_enrollled.Text = "0";
            this.dashboard_enrollled.Click += new System.EventHandler(this.dashboard_enrollled_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Register";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(924, 429);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(930, 621);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashboard_enrollled;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label dashboard_dropout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dashboard_graduates;
    }
}
