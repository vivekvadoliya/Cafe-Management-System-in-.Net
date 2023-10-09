using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project_Cafe_Management_System.Usercontrol
{
    public partial class Update_item : UserControl
    {
        function fn = new function();
        string query;

        public Update_item()
        {
            InitializeComponent();
        }

        private void Update_item_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata ()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox_search_TextChanged(object sender, EventArgs e)
        {
            query = "select name from items where name ='" + guna2TextBox_search.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource= ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txt_category.Text = category;
            txt_name.Text = name;
            txt_price.Text = price.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            query = "update items set name= '" + txt_name.Text + "' ,category ='" + txt_category.Text + "' ,price ="+txt_price.Text + " where id =" + id + "";
            fn.getData(query);
            loaddata();
        }
    }
}
