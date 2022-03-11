﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using ClassLibraryCJMKLtd;

namespace BackEnd
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            displayOrders("");
        }

        public void displayOrders(string format)
        {
            List<clsOrder> orderList = new List<clsOrder>();

            //variable to store the primary key
            Int32 OrderID;
            //variable to store the video game
            decimal Price;
            //variable to store the format
            Int32 UserID;
            //variable to store the age rating
            DateTime OrderDate;
            //
            string Status;
            //create an instance of the video game class
            clsOrder DVD = new clsOrder();
            //
            if (format == "")
            {
                orderList = DVD.SelectAll();
            }
            else
            {
                int userid = Convert.ToInt32(format);
                orderList = DVD.FilterByUserID(userid);
            }
            //variable to store the amount of records
            Int32 RecordCount;
            //variable to store the indes of the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = orderList.Count;
            //clear the list box
            lstDVD.Items.Clear();
            List<KeyValuePair<int, string>> listItems = new List<KeyValuePair<int, string>>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                OrderID = orderList[Index].OrderId;
                //get the video game
                Price = orderList[Index].TotalPrice;
                //get the format
                UserID = orderList[Index].UserID;
                //get the format
                OrderDate = orderList[Index].OrderDate;
                //get the format
                Status = orderList[Index].Status;
                //create a new entry for the list box
                KeyValuePair<int, string> listitem = new KeyValuePair<int, string>(OrderID, string.Format("{0} {1} {2} {3}", UserID, Price, OrderDate.ToShortDateString(), Status));
                //add the video game to the list
                listItems.Add(listitem);
                
                //move the index to the next record
                Index++;
            }

            lstDVD.DataSource = listItems;
            lstDVD.ValueMember = "Key";
            lstDVD.DisplayMember = "Value";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string orderItem = lstDVD.SelectedValue.ToString();
            MessageBox.Show(orderItem);
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //variable to store the video game no
            Int32 OrderId;

            //if (lstDVD.SelectedIndex != -1)
            //{
            //    //get the primary key value from the list box
            //    OrderId = Convert.ToInt32(lstDVD.SelectedValue);
            //    lstDVD.Items.Remove(lstDVD.SelectedItem);
                //
                //reRedirect("Delete.aspx?VideoGameNo=" + VideoGameNo);
            }
            //else
            //{
            //    //display an error
            //    //lblError.Text = "you must select an item from the list to delete!";
            //}
    }
}
