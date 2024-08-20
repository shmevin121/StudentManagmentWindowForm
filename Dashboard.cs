using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudendLogin
{
    public partial class Dashboard : UserControl
    {
        //------------creating the connection--------------------------------
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koola\OneDrive\Documents\StudentLoginFile.mdf;Integrated Security=True;Connect Timeout=30");
        //------------------------------------------------------------------------
       

        public Dashboard()
        {
            InitializeComponent();
            displaytotal();//displays the total number of students enrolled on the dashboard
            displaytotalGrads();// displays total graduates on the dashboard
            displaydropout();// shows the total dropouts
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            displaytotal();
            displaytotalGrads();
            displaydropout();
        }
        public void displaytotalGrads()
        {
            //displays the total graduates from the data base
            if(connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string totalgrads = "SELECT COUNT(Id) FROM StudentsReg WHERE StudentsGraduationDate = @StudentsGrads";
                    using (SqlCommand command = new SqlCommand(totalgrads, connection))
                    {
                        command.Parameters.AddWithValue("@StudentsGrads", "Yes");
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            double count = Convert.ToInt32(reader[0]);
                            dashboard_graduates.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to connect to data base " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void displaydropout()//display drop outs
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string Totalstudents = "SELECT COUNT(Id) FROM StudentsReg WHERE StudentsDropOut = @Studentdropout";
                    using (SqlCommand command = new SqlCommand(Totalstudents,connection))
                    {
                        command.Parameters.AddWithValue("@Studentdropout", "Yes");
                        SqlDataReader reader = command.ExecuteReader();
                        
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_dropout.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void displaytotal()// display the total students enrolled
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string Totalstudents = "SELECT COUNT(Id) FROM StudentsReg";
                    using (SqlCommand command = new SqlCommand(Totalstudents, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_enrollled.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_enrollled_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_graduates_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
