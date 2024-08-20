using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudendLogin
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void main_closeBtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void main_dashboardbtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addStudents1.Visible = false;

            Dashboard dashform = dashboard1 as Dashboard;

            if(dashform != null)
            {
                dashform.RefreshData();
            }


        }
        

        private void main_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confimation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                signIn form1 = new signIn();
                form1.Show();
                this.Hide();
            }
        }

        private void main_addStudentBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addStudents1.Visible = true;

            addStudents addst = addStudents1 as addStudents;
            if(addst != null)
            {

            addst.RefreshData(); 
            }
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
