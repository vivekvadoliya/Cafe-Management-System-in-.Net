using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Project_Cafe_Management_System
{
    public partial class Login_page : Form
    {
        string user;
        public Login_page()
        {
            InitializeComponent();
        }
        private void guna2Button_login_DragEnter(object sender, DragEventArgs e)
        {
                BackColor = Color.DodgerBlue;
                ForeColor = Color.White;
        }
        private void guna2Button_login_Click(object sender, EventArgs e)
        {
            if (guna2TextBox_Username.Text == "Admin" && guna2TextBox_Password.Text == "6897") 
            {
                Dashbord ds = new Dashbord();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }
    }
}