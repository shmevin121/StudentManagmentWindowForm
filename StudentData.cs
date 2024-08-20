using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudendLogin
{
    internal class StudentData
    {
        //---------------setting the connection string--------------------
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koola\OneDrive\Documents\StudentLoginFile.mdf;Integrated Security=True;Connect Timeout=30");
        //-----------------------------------------------------------------
        public int Id { get; set; } //0
        public string StudentsFistName {get; set; }// 1
        public string StudentsLastName {get; set; }// 2
        public string StudentsMajor { get; set; }// 3
        public string StudentsGender { get; set; }// 4
        public string StudentsImage { get; set; }// 5
        public string StudentsID { get; set; } // 6
        public string StudentsGraduationDate { get; set; } // 7
        public string StudentsDropOut { get; set; } // 8
    
        //----------creating a list for StudentsData-------------------
        public List<StudentData> studentdata()
        {
            List<StudentData> listdata = new List<StudentData>();
            if(connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT * FROM StudentsReg";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            StudentData st = new StudentData();
                            st.Id = (int)reader["Id"];
                            st.StudentsFistName = reader["StudentsFirstName"].ToString();
                            st.StudentsLastName = reader["StudentsLastName"].ToString();
                            st.StudentsGender = reader["StudentsGender"].ToString();
                            st.StudentsMajor = reader["StudentsMajor"].ToString();
                            st.StudentsImage = reader["StudentsImage"].ToString();
                            st.StudentsID = reader["StudentsID"].ToString();
                            st.StudentsGraduationDate = reader["StudentsGraduationDate"].ToString();
                            st.StudentsDropOut = reader["StudentsDropOut"].ToString();
                            listdata.Add(st);
                        }


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not connect to database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                
            }
               
            return listdata;



        }


    }
}
