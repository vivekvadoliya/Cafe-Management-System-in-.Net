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

namespace C__Project_Cafe_Management_System.Usercontrol
{
    public partial class Delete_item : UserControl
    {
        function fn = new function();
        string query;

        public Delete_item()
        {
            InitializeComponent();
        }

        private void Delete_item_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox_search_TextChanged(object sender, EventArgs e)
        {
            query = "select name from items where name ='" + guna2TextBox_search.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id =" + id + "";
                fn.setData(query);
                loaddata();

            }
        }
    }
}
