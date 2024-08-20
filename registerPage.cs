using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------------------------------------
using System.Data.SqlClient;
//-----above is needed for connection to database--------

namespace StudendLogin
{
    public partial class registrationPage : Form
    {
        //-------------------making a connection-------------------
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koola\OneDrive\Documents\StudentLoginFile.mdf;Integrated Security=True;Connect Timeout=30");
        //----------------------------------------------------------
        public registrationPage()
        {
            InitializeComponent();
        }

        private void registrationPage_Load(object sender, EventArgs e)
        {

        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reg_signInbtn_Click(object sender, EventArgs e)
        {
            //the sign in button
            signIn signin = new signIn();
            signin.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            //the register button
            //checking first if the fields are empty
            if (Reg_Fname.Text == "" || Reg_Lname.Text == "" || DOB.Value == null || Reg_Password.Text == "" || Reg_UserName.Text == "")
            {
                //show error message if condition is true
                MessageBox.Show("Please fill in all the boxes to continue ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            //checking if connection is open
                if (connection.State != ConnectionState.Open)//checking if its not open open
                {
                    try
                    {
                        connection.Open();
                        //checking if user name exist 
                        String checkUsername = "SELECT COUNT (*) FROM studentlogin WHERE UserName = @UserName";
                        using(SqlCommand cmd = new SqlCommand(checkUsername,connection))
                        {
                            cmd.Parameters.AddWithValue("@UserName", Reg_UserName.Text.Trim());
                            //coverting the cmd into an integer
                            int count = (int)cmd.ExecuteScalar();
                            //error message is thrown if username exist
                            if (count >= 1)
                            {
                                MessageBox.Show(Reg_UserName.Text + " is already taken", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                //below inserts the data to the table from values from form
                                String insertData = "INSERT INTO studentlogin (FirstName, LastName, DateofBirth, UserName, Password)" +
                                    "VALUES (@FirstName, @LastName, @DateofBirth, @UserName, @Password)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, connection))
                                {
                                    insertCMD.Parameters.AddWithValue("@FirstName", Reg_Fname.Text);
                                    insertCMD.Parameters.AddWithValue("@LastName", Reg_Lname.Text);
                                    insertCMD.Parameters.AddWithValue("@DateofBirth", DOB.Value);
                                    insertCMD.Parameters.AddWithValue("@UserName", Reg_UserName.Text);
                                    insertCMD.Parameters.AddWithValue("@Password", Reg_Password.Text);

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successful ", "Information Message ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //after registration; it sends you back to the sign in page
                                    signIn signin = new signIn();
                                    signin.Show();
                                    this.Hide();

                                }
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        //throws error message is problem arose connecting
                        MessageBox.Show("Error connecting to database " + ex, "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
