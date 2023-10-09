using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project_Cafe_Management_System.Usercontrol
{
    public partial class Add_item : UserControl
    {
        function fn = new function();
        string query;
        public Add_item()
        {
            InitializeComponent();
        }

        private void guna2Button_add_item_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values('" + guna2TextBox_item_name.Text + "','" + guna2ComboBox_category.Text + "'," + guna2TextBox_price.Text + ")";
            fn.setData(query);
            clearall();
        }

        public void clearall()
        {
            guna2ComboBox_category.SelectedIndex = -1;
            guna2TextBox_item_name.Clear();
            guna2TextBox_price.Clear();
        }
    }
}
