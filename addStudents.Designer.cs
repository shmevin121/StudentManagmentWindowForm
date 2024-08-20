namespace StudendLogin
{
    partial class addStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStudents_addbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addstudents_IDnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addStudents_major = new System.Windows.Forms.TextBox();
            this.addStudents_lname = new System.Windows.Forms.TextBox();
            this.addStudents_fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStudents_combobox = new System.Windows.Forms.ComboBox();
            this.addStudents_fnamelabel = new System.Windows.Forms.Label();
            this.addStudents_importbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addStudent_deletebtn = new System.Windows.Forms.Button();
            this.addStudent_updatebtn = new System.Windows.Forms.Button();
            this.addStudent_clearbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addStudents_dropout = new System.Windows.Forms.ComboBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.addStudents_graduate = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 300);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students that are enrolled";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(865, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addStudents_addbtn
            // 
            this.addStudents_addbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addStudents_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudents_addbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_addbtn.Location = new System.Drawing.Point(16, 27);
            this.addStudents_addbtn.Name = "addStudents_addbtn";
            this.addStudents_addbtn.Size = new System.Drawing.Size(76, 35);
            this.addStudents_addbtn.TabIndex = 1;
            this.addStudents_addbtn.Text = "Add";
            this.addStudents_addbtn.UseVisualStyleBackColor = false;
            this.addStudents_addbtn.Click += new System.EventHandler(this.addStudents_addbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addStudents_graduate);
            this.panel2.Controls.Add(this.addStudents_dropout);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addstudents_IDnumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addStudents_major);
            this.panel2.Controls.Add(this.addStudents_lname);
            this.panel2.Controls.Add(this.addStudents_fname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addStudents_combobox);
            this.panel2.Controls.Add(this.addStudents_fnamelabel);
            this.panel2.Controls.Add(this.addStudents_importbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.addStudent_deletebtn);
            this.panel2.Controls.Add(this.addStudent_updatebtn);
            this.panel2.Controls.Add(this.addStudent_clearbtn);
            this.panel2.Controls.Add(this.addStudents_addbtn);
            this.panel2.Location = new System.Drawing.Point(13, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 236);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addstudents_IDnumber
            // 
            this.addstudents_IDnumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudents_IDnumber.Location = new System.Drawing.Point(220, 156);
            this.addstudents_IDnumber.Name = "addstudents_IDnumber";
            this.addstudents_IDnumber.Size = new System.Drawing.Size(250, 27);
            this.addstudents_IDnumber.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Students ID";
            // 
            // addStudents_major
            // 
            this.addStudents_major.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_major.Location = new System.Drawing.Point(498, 96);
            this.addStudents_major.Name = "addStudents_major";
            this.addStudents_major.Size = new System.Drawing.Size(250, 27);
            this.addStudents_major.TabIndex = 16;
            // 
            // addStudents_lname
            // 
            this.addStudents_lname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_lname.Location = new System.Drawing.Point(219, 96);
            this.addStudents_lname.Name = "addStudents_lname";
            this.addStudents_lname.Size = new System.Drawing.Size(247, 27);
            this.addStudents_lname.TabIndex = 15;
            // 
            // addStudents_fname
            // 
            this.addStudents_fname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_fname.Location = new System.Drawing.Point(217, 27);
            this.addStudents_fname.Name = "addStudents_fname";
            this.addStudents_fname.Size = new System.Drawing.Size(249, 27);
            this.addStudents_fname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Major";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addStudents_combobox
            // 
            this.addStudents_combobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_combobox.FormattingEnabled = true;
            this.addStudents_combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.addStudents_combobox.Location = new System.Drawing.Point(498, 27);
            this.addStudents_combobox.Name = "addStudents_combobox";
            this.addStudents_combobox.Size = new System.Drawing.Size(121, 27);
            this.addStudents_combobox.TabIndex = 10;
            this.addStudents_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addStudents_fnamelabel
            // 
            this.addStudents_fnamelabel.AutoSize = true;
            this.addStudents_fnamelabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_fnamelabel.Location = new System.Drawing.Point(213, 5);
            this.addStudents_fnamelabel.Name = "addStudents_fnamelabel";
            this.addStudents_fnamelabel.Size = new System.Drawing.Size(85, 19);
            this.addStudents_fnamelabel.TabIndex = 7;
            this.addStudents_fnamelabel.Text = "First Name";
            // 
            // addStudents_importbtn
            // 
            this.addStudents_importbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addStudents_importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudents_importbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_importbtn.Location = new System.Drawing.Point(801, 132);
            this.addStudents_importbtn.Name = "addStudents_importbtn";
            this.addStudents_importbtn.Size = new System.Drawing.Size(80, 30);
            this.addStudents_importbtn.TabIndex = 6;
            this.addStudents_importbtn.Text = "Import";
            this.addStudents_importbtn.UseVisualStyleBackColor = false;
            this.addStudents_importbtn.Click += new System.EventHandler(this.addStudents_importbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(768, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // addStudent_deletebtn
            // 
            this.addStudent_deletebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addStudent_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent_deletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent_deletebtn.Location = new System.Drawing.Point(16, 91);
            this.addStudent_deletebtn.Name = "addStudent_deletebtn";
            this.addStudent_deletebtn.Size = new System.Drawing.Size(76, 35);
            this.addStudent_deletebtn.TabIndex = 4;
            this.addStudent_deletebtn.Text = "Delete";
            this.addStudent_deletebtn.UseVisualStyleBackColor = false;
            this.addStudent_deletebtn.Click += new System.EventHandler(this.addStudent_deletebtn_Click);
            // 
            // addStudent_updatebtn
            // 
            this.addStudent_updatebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addStudent_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent_updatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent_updatebtn.Location = new System.Drawing.Point(126, 27);
            this.addStudent_updatebtn.Name = "addStudent_updatebtn";
            this.addStudent_updatebtn.Size = new System.Drawing.Size(76, 35);
            this.addStudent_updatebtn.TabIndex = 3;
            this.addStudent_updatebtn.Text = "Update";
            this.addStudent_updatebtn.UseVisualStyleBackColor = false;
            this.addStudent_updatebtn.Click += new System.EventHandler(this.addStudent_updatebtn_Click);
            // 
            // addStudent_clearbtn
            // 
            this.addStudent_clearbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addStudent_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent_clearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent_clearbtn.Location = new System.Drawing.Point(126, 91);
            this.addStudent_clearbtn.Name = "addStudent_clearbtn";
            this.addStudent_clearbtn.Size = new System.Drawing.Size(76, 35);
            this.addStudent_clearbtn.TabIndex = 2;
            this.addStudent_clearbtn.Text = "Clear";
            this.addStudent_clearbtn.UseVisualStyleBackColor = false;
            this.addStudent_clearbtn.Click += new System.EventHandler(this.addStudent_clearbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Graduated ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Drop out student?";
            // 
            // addStudents_dropout
            // 
            this.addStudents_dropout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_dropout.FormattingEnabled = true;
            this.addStudents_dropout.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.addStudents_dropout.Location = new System.Drawing.Point(16, 156);
            this.addStudents_dropout.Name = "addStudents_dropout";
            this.addStudents_dropout.Size = new System.Drawing.Size(121, 28);
            this.addStudents_dropout.TabIndex = 23;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // addStudents_graduate
            // 
            this.addStudents_graduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_graduate.FormattingEnabled = true;
            this.addStudents_graduate.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.addStudents_graduate.Location = new System.Drawing.Point(498, 156);
            this.addStudents_graduate.Name = "addStudents_graduate";
            this.addStudents_graduate.Size = new System.Drawing.Size(121, 28);
            this.addStudents_graduate.TabIndex = 24;
            // 
            // addStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addStudents";
            this.Size = new System.Drawing.Size(930, 564);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addStudents_addbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addStudents_importbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addStudent_deletebtn;
        private System.Windows.Forms.Button addStudent_updatebtn;
        private System.Windows.Forms.Button addStudent_clearbtn;
        private System.Windows.Forms.ComboBox addStudents_combobox;
        private System.Windows.Forms.Label addStudents_fnamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addStudents_fname;
        private System.Windows.Forms.TextBox addStudents_major;
        private System.Windows.Forms.TextBox addStudents_lname;
        private System.Windows.Forms.TextBox addstudents_IDnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox addStudents_dropout;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.ComboBox addStudents_graduate;
    }
}
