namespace C__Project_Cafe_Management_System
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteitem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateitem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_additem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_placeorder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.wlecome2 = new C__Project_Cafe_Management_System.Usercontrol.Wlecome();
            this.delete_item1 = new C__Project_Cafe_Management_System.Usercontrol.Delete_item();
            this.update_item1 = new C__Project_Cafe_Management_System.Usercontrol.Update_item();
            this.place_order1 = new C__Project_Cafe_Management_System.Usercontrol.Place_order();
            this.add_item1 = new C__Project_Cafe_Management_System.Usercontrol.Add_item();
            this.wlecome1 = new C__Project_Cafe_Management_System.Usercontrol.Wlecome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btn_deleteitem);
            this.panel1.Controls.Add(this.btn_updateitem);
            this.panel1.Controls.Add(this.btn_additem);
            this.panel1.Controls.Add(this.btn_placeorder);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 750);
            this.panel1.TabIndex = 0;
            // 
            // btn_deleteitem
            // 
            this.btn_deleteitem.BorderRadius = 25;
            this.btn_deleteitem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_deleteitem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_deleteitem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_deleteitem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteitem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteitem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_deleteitem.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteitem.ForeColor = System.Drawing.Color.White;
            this.btn_deleteitem.Location = new System.Drawing.Point(30, 311);
            this.btn_deleteitem.Name = "btn_deleteitem";
            this.btn_deleteitem.Size = new System.Drawing.Size(232, 56);
            this.btn_deleteitem.TabIndex = 2;
            this.btn_deleteitem.Text = "Delete Item";
            this.btn_deleteitem.Click += new System.EventHandler(this.btn_deleteitem_Click);
            // 
            // btn_updateitem
            // 
            this.btn_updateitem.BorderRadius = 25;
            this.btn_updateitem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_updateitem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_updateitem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_updateitem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateitem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateitem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_updateitem.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateitem.ForeColor = System.Drawing.Color.White;
            this.btn_updateitem.Location = new System.Drawing.Point(30, 228);
            this.btn_updateitem.Name = "btn_updateitem";
            this.btn_updateitem.Size = new System.Drawing.Size(232, 56);
            this.btn_updateitem.TabIndex = 2;
            this.btn_updateitem.Text = "Update Item";
            this.btn_updateitem.Click += new System.EventHandler(this.btn_updateitem_Click);
            // 
            // btn_additem
            // 
            this.btn_additem.BorderRadius = 25;
            this.btn_additem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_additem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_additem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_additem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_additem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_additem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_additem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_additem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_additem.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_additem.ForeColor = System.Drawing.Color.White;
            this.btn_additem.Location = new System.Drawing.Point(30, 143);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(232, 56);
            this.btn_additem.TabIndex = 2;
            this.btn_additem.Text = "Add Item";
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // btn_placeorder
            // 
            this.btn_placeorder.BorderRadius = 20;
            this.btn_placeorder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_placeorder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_placeorder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_placeorder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_placeorder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_placeorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_placeorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_placeorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_placeorder.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_placeorder.ForeColor = System.Drawing.Color.White;
            this.btn_placeorder.Location = new System.Drawing.Point(30, 60);
            this.btn_placeorder.Name = "btn_placeorder";
            this.btn_placeorder.Size = new System.Drawing.Size(232, 56);
            this.btn_placeorder.TabIndex = 1;
            this.btn_placeorder.Text = "Place Order";
            this.btn_placeorder.Click += new System.EventHandler(this.btn_placeorder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wlecome2);
            this.panel2.Controls.Add(this.delete_item1);
            this.panel2.Controls.Add(this.update_item1);
            this.panel2.Controls.Add(this.place_order1);
            this.panel2.Controls.Add(this.add_item1);
            this.panel2.Controls.Add(this.wlecome1);
            this.panel2.Location = new System.Drawing.Point(234, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 750);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 25;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveLinkColor = System.Drawing.Color.White;
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.LinkColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(65, 685);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 29);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // wlecome2
            // 
            this.wlecome2.BackColor = System.Drawing.Color.White;
            this.wlecome2.Location = new System.Drawing.Point(0, -3);
            this.wlecome2.Name = "wlecome2";
            this.wlecome2.Size = new System.Drawing.Size(1052, 750);
            this.wlecome2.TabIndex = 5;
            // 
            // delete_item1
            // 
            this.delete_item1.Location = new System.Drawing.Point(-3, -3);
            this.delete_item1.Name = "delete_item1";
            this.delete_item1.Size = new System.Drawing.Size(1052, 750);
            this.delete_item1.TabIndex = 4;
            // 
            // update_item1
            // 
            this.update_item1.Location = new System.Drawing.Point(0, -3);
            this.update_item1.Name = "update_item1";
            this.update_item1.Size = new System.Drawing.Size(1052, 750);
            this.update_item1.TabIndex = 3;
            // 
            // place_order1
            // 
            this.place_order1.Location = new System.Drawing.Point(0, 0);
            this.place_order1.Name = "place_order1";
            this.place_order1.Size = new System.Drawing.Size(1064, 796);
            this.place_order1.TabIndex = 2;
            // 
            // add_item1
            // 
            this.add_item1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.add_item1.Location = new System.Drawing.Point(-3, 0);
            this.add_item1.Name = "add_item1";
            this.add_item1.Size = new System.Drawing.Size(1052, 750);
            this.add_item1.TabIndex = 1;
            // 
            // wlecome1
            // 
            this.wlecome1.BackColor = System.Drawing.Color.White;
            this.wlecome1.Location = new System.Drawing.Point(-3, -3);
            this.wlecome1.Name = "wlecome1";
            this.wlecome1.Size = new System.Drawing.Size(1052, 750);
            this.wlecome1.TabIndex = 0;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_placeorder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_deleteitem;
        private Guna.UI2.WinForms.Guna2Button btn_updateitem;
        private Guna.UI2.WinForms.Guna2Button btn_additem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Usercontrol.Wlecome wlecome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Usercontrol.Add_item add_item1;
        private Usercontrol.Place_order place_order1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Usercontrol.Update_item update_item1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Usercontrol.Delete_item delete_item1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Usercontrol.Wlecome wlecome2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private System.Windows.Forms.LinkLabel btnLogout;
    }
}