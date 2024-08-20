using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------------
using System.Data.SqlClient;
//----above is the require namespace for connection------

namespace StudendLogin
{
    public partial class signIn : Form
    {
        //-------------------below is the connection string----------------------
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koola\OneDrive\Documents\StudentLoginFile.mdf;Integrated Security=True;Connect Timeout=30");
        //--------------------------------------------------
        public signIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            registrationPage registrationPage = new registrationPage();
            registrationPage.Show();
            this.Hide();
        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            //sign in button
            if(signIn_username.Text == "" || signIn_password.Text=="")
            {
                MessageBox.Show("Please fill in all fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connection.Open();
                    String selectData = "SELECT * FROM studentlogin WHERE UserName = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", signIn_username.Text);
                        cmd.Parameters.AddWithValue("@Password", signIn_password.Text);
                        //---below allows access to review the data table 
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successful ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainform mform = new mainform();
                            mform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("The username or password is incorrect", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                        


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connecting to database " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close(); 
                }

            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {

        }
    }
}
