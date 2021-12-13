namespace Practice_06.Views
{
    partial class ReportsView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.DataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceManagmentDataSet = new Practice_06.InvoiceManagmentDataSet();
            this.TextBoxInfoUser = new System.Windows.Forms.TextBox();
            this.ComboBoxReportsCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.DataGridViewNewProduct = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxReportCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceManagmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceManagmentDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceManagmentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.TextBoxInfoUser);
            this.tabPage1.Controls.Add(this.ComboBoxReportsCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualize";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxTotal);
            this.groupBox1.Controls.Add(this.DataGridViewProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Location = new System.Drawing.Point(337, 182);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.ReadOnly = true;
            this.TextBoxTotal.Size = new System.Drawing.Size(126, 20);
            this.TextBoxTotal.TabIndex = 1;
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToAddRows = false;
            this.DataGridViewProducts.AllowUserToDeleteRows = false;
            this.DataGridViewProducts.AutoGenerateColumns = false;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.DataGridViewProducts.DataSource = this.productBindingSource;
            this.DataGridViewProducts.Location = new System.Drawing.Point(68, 19);
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.Size = new System.Drawing.Size(342, 150);
            this.DataGridViewProducts.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.invoiceManagmentDataSet;
            // 
            // invoiceManagmentDataSet
            // 
            this.invoiceManagmentDataSet.DataSetName = "InvoiceManagmentDataSet";
            this.invoiceManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextBoxInfoUser
            // 
            this.TextBoxInfoUser.Location = new System.Drawing.Point(171, 23);
            this.TextBoxInfoUser.Multiline = true;
            this.TextBoxInfoUser.Name = "TextBoxInfoUser";
            this.TextBoxInfoUser.ReadOnly = true;
            this.TextBoxInfoUser.Size = new System.Drawing.Size(310, 82);
            this.TextBoxInfoUser.TabIndex = 2;
            // 
            // ComboBoxReportsCode
            // 
            this.ComboBoxReportsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxReportsCode.FormattingEnabled = true;
            this.ComboBoxReportsCode.Location = new System.Drawing.Point(12, 42);
            this.ComboBoxReportsCode.Name = "ComboBoxReportsCode";
            this.ComboBoxReportsCode.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxReportsCode.TabIndex = 1;
            this.ComboBoxReportsCode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReportsCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.DateTimePickerPurchase);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TextBoxClient);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TextBoxReportCode);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonSave);
            this.groupBox2.Controls.Add(this.DataGridViewNewProduct);
            this.groupBox2.Location = new System.Drawing.Point(44, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 185);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the products and enter the quantity";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.Navy;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonSave.Location = new System.Drawing.Point(85, 135);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(241, 39);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // DataGridViewNewProduct
            // 
            this.DataGridViewNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewNewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Products,
            this.Quantity});
            this.DataGridViewNewProduct.Location = new System.Drawing.Point(85, 19);
            this.DataGridViewNewProduct.Name = "DataGridViewNewProduct";
            this.DataGridViewNewProduct.Size = new System.Drawing.Size(241, 105);
            this.DataGridViewNewProduct.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // DateTimePickerPurchase
            // 
            this.DateTimePickerPurchase.Location = new System.Drawing.Point(197, 117);
            this.DateTimePickerPurchase.Name = "DateTimePickerPurchase";
            this.DateTimePickerPurchase.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerPurchase.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 117);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date purchase";
            // 
            // TextBoxClient
            // 
            this.TextBoxClient.Location = new System.Drawing.Point(196, 71);
            this.TextBoxClient.Name = "TextBoxClient";
            this.TextBoxClient.Size = new System.Drawing.Size(201, 20);
            this.TextBoxClient.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client name";
            // 
            // TextBoxReportCode
            // 
            this.TextBoxReportCode.Location = new System.Drawing.Point(196, 21);
            this.TextBoxReportCode.Name = "TextBoxReportCode";
            this.TextBoxReportCode.Size = new System.Drawing.Size(201, 20);
            this.TextBoxReportCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Report code";
            // 
            // invoiceManagmentDataSetBindingSource
            // 
            this.invoiceManagmentDataSetBindingSource.DataSource = this.invoiceManagmentDataSet;
            this.invoiceManagmentDataSetBindingSource.Position = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 369);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "ReportsView";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceManagmentDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceManagmentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox TextBoxInfoUser;
        public System.Windows.Forms.ComboBox ComboBoxReportsCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DataGridViewProducts;
        private InvoiceManagmentDataSet invoiceManagmentDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.BindingSource invoiceManagmentDataSetBindingSource;
        public System.Windows.Forms.TextBox TextBoxReportCode;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TextBoxClient;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker DateTimePickerPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DataGridViewNewProduct;
        public System.Windows.Forms.DataGridViewComboBoxColumn Products;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}