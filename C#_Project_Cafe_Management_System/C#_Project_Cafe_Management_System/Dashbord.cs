using System;
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
        public Dashbord(string username)
        {
            InitializeComponent();
            if (username == "Employee")
            {
                guna2Button_Add_item.Hide();
                guna2Button_update_item.Hide();
                guna2Button_remove_item.Hide();
                guna2Button_remove_employee.Hide();
                guna2Button_add_employee.Hide();
            }
            if (username == "Admin")
            {
                guna2Button_Palce_order.Show();
                guna2Button_Add_item.Show();
                guna2Button_update_item.Show();
                guna2Button_remove_item.Show();
                guna2Button_remove_employee.Show();
                guna2Button_add_employee.Show();
            }
        }

        private void guna2Button_Palce_order_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button_remove_employee_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button_Add_item_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Button_update_item_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button_remove_item_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button_add_employee_Click(object sender, EventArgs e)
        {
            
        }
    }
}
