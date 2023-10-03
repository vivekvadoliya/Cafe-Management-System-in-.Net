using DGVPrinterHelper;
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
    public partial class Place_order : UserControl
    {
        function fn = new function();
        string query;
        public Place_order()
        {
            InitializeComponent();
        }

        private void txt_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = txt_category.Text;
            query = "select name from items where category = '"+category+"'";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            } 
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = txt_category.Text;
            query = "select name from items where category = '" + category + "' and  name like '"+txt_search.Text+ "%'";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_itemname.Clear();
            txt_price.Clear();
            txt_quantity.ResetText();
            txt_total.Clear();

            string text =listBox1.GetItemText(listBox1.SelectedItem);
            txt_itemname.Text = text;
            query = "select price from items where name = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                txt_price.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }

        private void txt_quantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txt_quantity.Value.ToString());
            Int64 price = Int64.Parse(txt_price.Text);
            txt_total.Text = (quan*price).ToString();
        }
        protected int n, total = 0;

        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount= int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try 
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            lab_totalamount.Text = "Rs " + total;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Bill";
            printer.SubTitle = string.Format("Date: {0}",DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + lab_totalamount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);


            total = 0;
            guna2DataGridView1.Rows.Clear();
            lab_totalamount.Text = "Rs " + total;
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            if (txt_total.Text != "0" && txt_total.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txt_itemname.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txt_price.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txt_quantity.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txt_total.Text;

                total = total + int.Parse(txt_total.Text);
                lab_totalamount.Text = "Rs " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity Need to be 1","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
