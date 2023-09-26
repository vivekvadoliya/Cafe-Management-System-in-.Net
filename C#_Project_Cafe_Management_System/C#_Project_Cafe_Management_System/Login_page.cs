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
        string username;
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
            guna2TextBox_Username.Text = username;
            Dashbord ds = new Dashbord(username);
            ds.Show();
            this.Hide();
    
        }
    }
}