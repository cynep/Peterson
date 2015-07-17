using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.InvoiceList' table. You can move, or remove it, as needed.
            this.invoiceListTableAdapter.Fill(this.database1DataSet.InvoiceList);
            // TODO: This line of code loads data into the 'database1DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet.Customer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customerBindingSource.AddNew();
                this.invoiceListBindingSource.AddNew();
                
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please fill in required data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
