namespace Peterson
{
    partial class Form1
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
            System.Windows.Forms.Label invoice_NumberLabel;
            System.Windows.Forms.Label car_YearLabel;
            System.Windows.Forms.Label car_MakeLabel;
            System.Windows.Forms.Label car_ModelLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label invoice_DateLabel;
            this.database1DataSet = new Peterson.Database1DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Peterson.Database1DataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Peterson.Database1DataSetTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.invoiceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceListTableAdapter = new Peterson.Database1DataSetTableAdapters.InvoiceListTableAdapter();
            this.invoice_NumberTextBox = new System.Windows.Forms.TextBox();
            this.car_YearTextBox = new System.Windows.Forms.TextBox();
            this.car_MakeTextBox = new System.Windows.Forms.TextBox();
            this.car_ModelTextBox = new System.Windows.Forms.TextBox();
            this.VINTextBox = new System.Windows.Forms.TextBox();
            this.invoice_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchPhone = new System.Windows.Forms.Button();
            this.searchVIN = new System.Windows.Forms.Button();
            this.searchInvoice = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textVIN = new System.Windows.Forms.TextBox();
            this.textInvoice = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            invoice_NumberLabel = new System.Windows.Forms.Label();
            car_YearLabel = new System.Windows.Forms.Label();
            car_MakeLabel = new System.Windows.Forms.Label();
            car_ModelLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            invoice_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_NumberLabel
            // 
            invoice_NumberLabel.AutoSize = true;
            invoice_NumberLabel.Location = new System.Drawing.Point(515, 37);
            invoice_NumberLabel.Name = "invoice_NumberLabel";
            invoice_NumberLabel.Size = new System.Drawing.Size(85, 13);
            invoice_NumberLabel.TabIndex = 18;
            invoice_NumberLabel.Text = "Invoice Number:";
            // 
            // car_YearLabel
            // 
            car_YearLabel.AutoSize = true;
            car_YearLabel.Location = new System.Drawing.Point(515, 124);
            car_YearLabel.Name = "car_YearLabel";
            car_YearLabel.Size = new System.Drawing.Size(51, 13);
            car_YearLabel.TabIndex = 20;
            car_YearLabel.Text = "Car Year:";
            // 
            // car_MakeLabel
            // 
            car_MakeLabel.AutoSize = true;
            car_MakeLabel.Location = new System.Drawing.Point(515, 150);
            car_MakeLabel.Name = "car_MakeLabel";
            car_MakeLabel.Size = new System.Drawing.Size(56, 13);
            car_MakeLabel.TabIndex = 22;
            car_MakeLabel.Text = "Car Make:";
            // 
            // car_ModelLabel
            // 
            car_ModelLabel.AutoSize = true;
            car_ModelLabel.Location = new System.Drawing.Point(515, 176);
            car_ModelLabel.Name = "car_ModelLabel";
            car_ModelLabel.Size = new System.Drawing.Size(58, 13);
            car_ModelLabel.TabIndex = 24;
            car_ModelLabel.Text = "Car Model:";
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(515, 89);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(28, 13);
            vINLabel.TabIndex = 26;
            vINLabel.Text = "VIN:";
            // 
            // invoice_DateLabel
            // 
            invoice_DateLabel.AutoSize = true;
            invoice_DateLabel.Location = new System.Drawing.Point(515, 64);
            invoice_DateLabel.Name = "invoice_DateLabel";
            invoice_DateLabel.Size = new System.Drawing.Size(71, 13);
            invoice_DateLabel.TabIndex = 28;
            invoice_DateLabel.Text = "Invoice Date:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.database1DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.InvoiceListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Peterson.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 329);
            this.listBox1.TabIndex = 0;
            // 
            // invoiceListBindingSource
            // 
            this.invoiceListBindingSource.DataMember = "FK_InvoiceList_ToCustomer";
            this.invoiceListBindingSource.DataSource = this.customerBindingSource;
            // 
            // invoiceListTableAdapter
            // 
            this.invoiceListTableAdapter.ClearBeforeFill = true;
            // 
            // invoice_NumberTextBox
            // 
            this.invoice_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Invoice_Number", true));
            this.invoice_NumberTextBox.Location = new System.Drawing.Point(606, 34);
            this.invoice_NumberTextBox.Name = "invoice_NumberTextBox";
            this.invoice_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoice_NumberTextBox.TabIndex = 19;
            // 
            // car_YearTextBox
            // 
            this.car_YearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Year", true));
            this.car_YearTextBox.Location = new System.Drawing.Point(606, 121);
            this.car_YearTextBox.Name = "car_YearTextBox";
            this.car_YearTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_YearTextBox.TabIndex = 21;
            // 
            // car_MakeTextBox
            // 
            this.car_MakeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Make", true));
            this.car_MakeTextBox.Location = new System.Drawing.Point(606, 147);
            this.car_MakeTextBox.Name = "car_MakeTextBox";
            this.car_MakeTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_MakeTextBox.TabIndex = 23;
            // 
            // car_ModelTextBox
            // 
            this.car_ModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Model", true));
            this.car_ModelTextBox.Location = new System.Drawing.Point(606, 173);
            this.car_ModelTextBox.Name = "car_ModelTextBox";
            this.car_ModelTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_ModelTextBox.TabIndex = 25;
            // 
            // VINTextBox
            // 
            this.VINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "VIN", true));
            this.VINTextBox.Location = new System.Drawing.Point(606, 86);
            this.VINTextBox.Name = "VINTextBox";
            this.VINTextBox.Size = new System.Drawing.Size(200, 20);
            this.VINTextBox.TabIndex = 27;
            // 
            // invoice_DateDateTimePicker
            // 
            this.invoice_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceListBindingSource, "Invoice_Date", true));
            this.invoice_DateDateTimePicker.Location = new System.Drawing.Point(606, 60);
            this.invoice_DateDateTimePicker.Name = "invoice_DateDateTimePicker";
            this.invoice_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoice_DateDateTimePicker.TabIndex = 29;
            // 
            // searchPhone
            // 
            this.searchPhone.Location = new System.Drawing.Point(39, 157);
            this.searchPhone.Name = "searchPhone";
            this.searchPhone.Size = new System.Drawing.Size(181, 23);
            this.searchPhone.TabIndex = 30;
            this.searchPhone.Text = "Search By Phone Number";
            this.searchPhone.UseVisualStyleBackColor = true;
            // 
            // searchVIN
            // 
            this.searchVIN.Location = new System.Drawing.Point(39, 245);
            this.searchVIN.Name = "searchVIN";
            this.searchVIN.Size = new System.Drawing.Size(181, 23);
            this.searchVIN.TabIndex = 31;
            this.searchVIN.Text = "Search By VIN#";
            this.searchVIN.UseVisualStyleBackColor = true;
            // 
            // searchInvoice
            // 
            this.searchInvoice.Location = new System.Drawing.Point(39, 334);
            this.searchInvoice.Name = "searchInvoice";
            this.searchInvoice.Size = new System.Drawing.Size(181, 23);
            this.searchInvoice.TabIndex = 32;
            this.searchInvoice.Text = "Search By Invoice #";
            this.searchInvoice.UseVisualStyleBackColor = true;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(39, 131);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(181, 20);
            this.textPhone.TabIndex = 33;
            // 
            // textVIN
            // 
            this.textVIN.Location = new System.Drawing.Point(39, 219);
            this.textVIN.Name = "textVIN";
            this.textVIN.Size = new System.Drawing.Size(181, 20);
            this.textVIN.TabIndex = 34;
            // 
            // textInvoice
            // 
            this.textInvoice.Location = new System.Drawing.Point(39, 308);
            this.textInvoice.Name = "textInvoice";
            this.textInvoice.Size = new System.Drawing.Size(181, 20);
            this.textInvoice.TabIndex = 35;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(518, 236);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(288, 41);
            this.viewButton.TabIndex = 36;
            this.viewButton.Text = "View Invoice";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(39, 37);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(180, 40);
            this.newButton.TabIndex = 37;
            this.newButton.Text = "New Invoice";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 396);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.textInvoice);
            this.Controls.Add(this.textVIN);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.searchInvoice);
            this.Controls.Add(this.searchVIN);
            this.Controls.Add(this.searchPhone);
            this.Controls.Add(invoice_NumberLabel);
            this.Controls.Add(this.invoice_NumberTextBox);
            this.Controls.Add(car_YearLabel);
            this.Controls.Add(this.car_YearTextBox);
            this.Controls.Add(car_MakeLabel);
            this.Controls.Add(this.car_MakeTextBox);
            this.Controls.Add(car_ModelLabel);
            this.Controls.Add(this.car_ModelTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.VINTextBox);
            this.Controls.Add(invoice_DateLabel);
            this.Controls.Add(this.invoice_DateDateTimePicker);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Peterson Car Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database1DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource invoiceListBindingSource;
        private Database1DataSetTableAdapters.InvoiceListTableAdapter invoiceListTableAdapter;
        private System.Windows.Forms.TextBox invoice_NumberTextBox;
        private System.Windows.Forms.TextBox car_YearTextBox;
        private System.Windows.Forms.TextBox car_MakeTextBox;
        private System.Windows.Forms.TextBox car_ModelTextBox;
        private System.Windows.Forms.TextBox VINTextBox;
        private System.Windows.Forms.DateTimePicker invoice_DateDateTimePicker;
        private System.Windows.Forms.Button searchPhone;
        private System.Windows.Forms.Button searchVIN;
        private System.Windows.Forms.Button searchInvoice;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textVIN;
        private System.Windows.Forms.TextBox textInvoice;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button newButton;
    }
}

