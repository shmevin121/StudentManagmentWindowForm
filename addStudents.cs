using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StudendLogin
{
    public partial class addStudents : UserControl
    {
        //------------creating the connection--------------------------------
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koola\OneDrive\Documents\StudentLoginFile.mdf;Integrated Security=True;Connect Timeout=30");
        //------------------------------------------------------------------------


        public addStudents()
        {
            InitializeComponent();
            //display the data to the gridview
            displayStudentsInfo();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
                
            }
            displayStudentsInfo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void displayStudentsInfo()
        {
            //display the objects for students
            StudentData st = new StudentData();
            List<StudentData> listData = st.studentdata();
            dataGridView1.DataSource = listData;
        }
        private void addStudents_addbtn_Click(object sender, EventArgs e)
        {
            //adding a student object button
            if (addStudents_fname.Text == "" || addStudents_lname.Text == ""
                || addStudents_combobox.Text == "" || addStudents_major.Text == "" ||
                pictureBox1.Image == null || addstudents_IDnumber.Text == "" )
            {
                MessageBox.Show("Please fill in all the boxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connection.Open();
                    string insertData = "INSERT INTO StudentsReg" + "(StudentsFirstName, StudentsLastName,StudentsMajor,StudentsGender, StudentsImage, StudentsID, StudentsGraduationDate, StudentsDropOut)" +
                        "VALUES (@StudentsFname,@StudentsLname,@StudentsMajor,@StudentsGender,@StudentsImage, @StudentsID, @StudentsGraduationdate, @StudentsdropOut)";

                    string path = Path.Combine(@"C:\Users\koola\OneDrive\Desktop\projects_c++.cpp\StudendLogin\StudendLogin\Directory\" + addstudents_IDnumber.Text +".jpg");

                    string directoryPath = Path.GetDirectoryName(path);
                    if(!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);

                    }
                    File.Copy(pictureBox1.ImageLocation,path,true);

                    using(SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentsFname", addStudents_fname.Text);
                        cmd.Parameters.AddWithValue("@StudentsLname", addStudents_lname.Text);
                        cmd.Parameters.AddWithValue("@StudentsMajor", addStudents_major.Text);
                        cmd.Parameters.AddWithValue("@StudentsGender", addStudents_combobox.Text);
                        cmd.Parameters.AddWithValue("@StudentsImage", path);
                        cmd.Parameters.AddWithValue("@StudentsID", addstudents_IDnumber.Text);
                        cmd.Parameters.AddWithValue("@StudentsGraduationdate", addStudents_graduate.Text);
                        cmd.Parameters.AddWithValue("@StudentsdropOut", addStudents_dropout.Text);
                        cmd.ExecuteNonQuery();
                        displayStudentsInfo();
                        MessageBox.Show("Insert Successful", "Information box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }


                    
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Failed to connect to the database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }

                
            }

        }

        private void addStudents_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "image files (*.jpg;*.png)|*.jpg;*.png";
                string imagepath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imagepath;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clearFields()
        {
            // makes all of the text box blank
            addStudents_fname.Text = "";
            addStudents_lname.Text = "";
            addStudents_major.Text = "";
            addStudents_combobox.Text = "";
            pictureBox1.Image = null;
            addstudents_IDnumber.Text = "";
            addStudents_dropout.Text = "";
            addStudents_graduate.Text = "";
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStudent_updatebtn_Click(object sender, EventArgs e)
        {
            //-----------------update button------------------------------------------------------
            if (addStudents_fname.Text == "" || addStudents_lname.Text == ""
               || addStudents_combobox.Text == "" || addStudents_major.Text == "" ||
               pictureBox1.Image == null || addstudents_IDnumber.Text == "" || addStudents_dropout.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //confirmation if the user wants to update
                DialogResult results = MessageBox.Show("Are you sure you want to update this student?", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (results == DialogResult.OK)
                {
                    try
                    {
                        connection.Open();
                        string updatestudent = "UPDATE StudentsReg SET StudentsFirstName = @StudentsFname, StudentsLastName = @StudentsLname, StudentsMajor = @StudentsMajor, StudentsGender = @StudentsGender, StudentsGraduationDate = @StudentsGraduationdate, StudentsDropOut = @StudentsdropOut WHERE StudentsID = @StudentsID";

                        using (SqlCommand cmd = new SqlCommand(updatestudent, connection))
                        {
                            cmd.Parameters.AddWithValue("@StudentsFname", addStudents_fname.Text);
                            cmd.Parameters.AddWithValue("@StudentsLname", addStudents_lname.Text);
                            cmd.Parameters.AddWithValue("@StudentsMajor", addStudents_major.Text);
                            cmd.Parameters.AddWithValue("@StudentsGender", addStudents_combobox.Text);
                            cmd.Parameters.AddWithValue("@StudentsID", addstudents_IDnumber.Text);
                            cmd.Parameters.AddWithValue("@StudentsGraduationdate", addStudents_graduate.Text);
                            cmd.Parameters.AddWithValue("@StudentsdropOut", addStudents_dropout.Text);

                            cmd.ExecuteNonQuery();
                            displayStudentsInfo();
                            MessageBox.Show("Update Successful", "Information box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to connect to the database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The student's information was not updated", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when clicking on a student the text boxes fill up
            //then you can update the student object
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addStudents_fname.Text = row.Cells[1].Value.ToString();
                addStudents_lname.Text = row.Cells[2].Value.ToString();
                addStudents_major.Text = row.Cells[3].Value.ToString();
                addStudents_combobox.Text = row.Cells[4].Value.ToString();

                string imagepath = row.Cells[5].Value.ToString();
                if (imagepath != null)
                {
                    pictureBox1.Image = Image.FromFile(imagepath);

                }
                else
                {
                    pictureBox1.Image = null;
                }
                addstudents_IDnumber.Text = row.Cells[6].Value.ToString();
                addStudents_graduate.Text = row.Cells[7].Value.ToString();
                addStudents_dropout.Text = row.Cells[8].Value.ToString();

            }
        }

        private void addStudent_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();//clears all text boxes from the add students user control
        }

        private void addStudent_deletebtn_Click(object sender, EventArgs e)
        {
            //------------to delete a student objwct-------------------
            if (addStudents_fname.Text == "" || addStudents_lname.Text == ""
               || addStudents_combobox.Text == "" || addStudents_major.Text == "" ||
               pictureBox1.Image == null || addstudents_IDnumber.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //confirmation if the user wants to update
                DialogResult results = MessageBox.Show("Are you sure you want to Delete this student? " + addStudents_fname.Text, "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (results == DialogResult.OK)
                {
                    try
                    {
                        connection.Open();
                        string updatestudent = "DELETE StudentsReg WHERE StudentsID = @StudentsId";

                        using (SqlCommand cmd = new SqlCommand(updatestudent, connection))
                        {
                           // cmd.Parameters.AddWithValue("@StudentsFname", addStudents_fname.Text);
                            //cmd.Parameters.AddWithValue("@StudentsLname", addStudents_lname.Text);
                            //cmd.Parameters.AddWithValue("@StudentsMajor", addStudents_major.Text);
                            cmd.Parameters.AddWithValue("@StudentsId", addstudents_IDnumber.Text);

                            cmd.ExecuteNonQuery();
                            displayStudentsInfo();
                            MessageBox.Show("Delete Successful", "Information box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to connect to the database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The student's information was not deleted", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
