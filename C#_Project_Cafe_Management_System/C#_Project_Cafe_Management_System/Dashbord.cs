using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project_Cafe_Management_System
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void btn_placeorder_Click(object sender, EventArgs e)
        {
            place_order1.BringToFront();
            place_order1.Visible = true;
            add_item1.Visible = false;
            update_item1.Visible = false;
            delete_item1.Visible = false;
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            add_item1.Visible = true;
            add_item1.BringToFront();
            update_item1.Visible = false;
            delete_item1.Visible = false;
        }

        private void btn_updateitem_Click(object sender, EventArgs e)
        {
            update_item1.Visible = true;
            update_item1.BringToFront();
            add_item1.Visible=false;
            place_order1.Visible=false;
            delete_item1.Visible=false;
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            delete_item1.Visible = true;
            delete_item1.BringToFront();
            update_item1.Visible=false;
            add_item1.Visible = false;
            place_order1.Visible=false;
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_page login_Page = new Login_page();
            this.Hide();
            login_Page.Show();
        }
    }
}
