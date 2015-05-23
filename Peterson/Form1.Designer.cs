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
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
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
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.invoiceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceListTableAdapter = new Peterson.Database1DataSetTableAdapters.InvoiceListTableAdapter();
            this.invoice_NumberTextBox = new System.Windows.Forms.TextBox();
            this.car_YearTextBox = new System.Windows.Forms.TextBox();
            this.car_MakeTextBox = new System.Windows.Forms.TextBox();
            this.car_ModelTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.invoice_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            last_NameLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
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
            this.listBox1.Size = new System.Drawing.Size(214, 485);
            this.listBox1.TabIndex = 0;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(36, 77);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 3;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(123, 74);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 4;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(36, 103);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 5;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(123, 100);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 6;
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(36, 129);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 7;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone_Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(123, 126);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_NumberTextBox.TabIndex = 8;
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(36, 155);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(79, 13);
            street_AddressLabel.TabIndex = 9;
            street_AddressLabel.Text = "Street Address:";
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Street_Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(123, 152);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_AddressTextBox.TabIndex = 10;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(36, 181);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(123, 178);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 12;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(36, 207);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(123, 204);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 14;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(36, 233);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(25, 13);
            zipLabel.TabIndex = 15;
            zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(123, 230);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 16;
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
            // invoice_NumberLabel
            // 
            invoice_NumberLabel.AutoSize = true;
            invoice_NumberLabel.Location = new System.Drawing.Point(515, 37);
            invoice_NumberLabel.Name = "invoice_NumberLabel";
            invoice_NumberLabel.Size = new System.Drawing.Size(85, 13);
            invoice_NumberLabel.TabIndex = 18;
            invoice_NumberLabel.Text = "Invoice Number:";
            // 
            // invoice_NumberTextBox
            // 
            this.invoice_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Invoice_Number", true));
            this.invoice_NumberTextBox.Location = new System.Drawing.Point(606, 34);
            this.invoice_NumberTextBox.Name = "invoice_NumberTextBox";
            this.invoice_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoice_NumberTextBox.TabIndex = 19;
            // 
            // car_YearLabel
            // 
            car_YearLabel.AutoSize = true;
            car_YearLabel.Location = new System.Drawing.Point(875, 36);
            car_YearLabel.Name = "car_YearLabel";
            car_YearLabel.Size = new System.Drawing.Size(51, 13);
            car_YearLabel.TabIndex = 20;
            car_YearLabel.Text = "Car Year:";
            // 
            // car_YearTextBox
            // 
            this.car_YearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Year", true));
            this.car_YearTextBox.Location = new System.Drawing.Point(966, 33);
            this.car_YearTextBox.Name = "car_YearTextBox";
            this.car_YearTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_YearTextBox.TabIndex = 21;
            // 
            // car_MakeLabel
            // 
            car_MakeLabel.AutoSize = true;
            car_MakeLabel.Location = new System.Drawing.Point(875, 62);
            car_MakeLabel.Name = "car_MakeLabel";
            car_MakeLabel.Size = new System.Drawing.Size(56, 13);
            car_MakeLabel.TabIndex = 22;
            car_MakeLabel.Text = "Car Make:";
            // 
            // car_MakeTextBox
            // 
            this.car_MakeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Make", true));
            this.car_MakeTextBox.Location = new System.Drawing.Point(966, 59);
            this.car_MakeTextBox.Name = "car_MakeTextBox";
            this.car_MakeTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_MakeTextBox.TabIndex = 23;
            // 
            // car_ModelLabel
            // 
            car_ModelLabel.AutoSize = true;
            car_ModelLabel.Location = new System.Drawing.Point(875, 88);
            car_ModelLabel.Name = "car_ModelLabel";
            car_ModelLabel.Size = new System.Drawing.Size(58, 13);
            car_ModelLabel.TabIndex = 24;
            car_ModelLabel.Text = "Car Model:";
            // 
            // car_ModelTextBox
            // 
            this.car_ModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "Car_Model", true));
            this.car_ModelTextBox.Location = new System.Drawing.Point(966, 85);
            this.car_ModelTextBox.Name = "car_ModelTextBox";
            this.car_ModelTextBox.Size = new System.Drawing.Size(200, 20);
            this.car_ModelTextBox.TabIndex = 25;
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
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceListBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(606, 86);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(200, 20);
            this.vINTextBox.TabIndex = 27;
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
            // invoice_DateDateTimePicker
            // 
            this.invoice_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceListBindingSource, "Invoice_Date", true));
            this.invoice_DateDateTimePicker.Location = new System.Drawing.Point(606, 60);
            this.invoice_DateDateTimePicker.Name = "invoice_DateDateTimePicker";
            this.invoice_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoice_DateDateTimePicker.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Search By Phone Number";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Search By VIN#";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Search By Invoice #";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 465);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 565);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(invoice_NumberLabel);
            this.Controls.Add(this.invoice_NumberTextBox);
            this.Controls.Add(car_YearLabel);
            this.Controls.Add(this.car_YearTextBox);
            this.Controls.Add(car_MakeLabel);
            this.Controls.Add(this.car_MakeTextBox);
            this.Controls.Add(car_ModelLabel);
            this.Controls.Add(this.car_ModelTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(invoice_DateLabel);
            this.Controls.Add(this.invoice_DateDateTimePicker);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.phone_NumberTextBox);
            this.Controls.Add(street_AddressLabel);
            this.Controls.Add(this.street_AddressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.BindingSource invoiceListBindingSource;
        private Database1DataSetTableAdapters.InvoiceListTableAdapter invoiceListTableAdapter;
        private System.Windows.Forms.TextBox invoice_NumberTextBox;
        private System.Windows.Forms.TextBox car_YearTextBox;
        private System.Windows.Forms.TextBox car_MakeTextBox;
        private System.Windows.Forms.TextBox car_ModelTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.DateTimePicker invoice_DateDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

