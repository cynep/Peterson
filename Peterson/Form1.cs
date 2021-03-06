﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peterson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//trying push
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.InvoiceList' table. You can move, or remove it, as needed.
            this.invoiceListTableAdapter.Fill(this.database1DataSet.InvoiceList);
            // TODO: This line of code loads data into the 'database1DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet.Customer);

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var newInvoice = new Form2();
            newInvoice.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                MessageBox.Show("Please select an invoice from the list", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var viewInvoice = new Form3();
                viewInvoice.Show();
            }
        }

       
    }
}
