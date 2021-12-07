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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceManagmentDataSet = new Practice_06.InvoiceManagmentDataSet();
            this.TextBoxInfoUser = new System.Windows.Forms.TextBox();
            this.ComboBoxReportsCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productTableAdapter = new Practice_06.InvoiceManagmentDataSetTableAdapters.ProductTableAdapter();
            this.invoiceManagmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceManagmentDataSet)).BeginInit();
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
            this.DataGridViewProducts.AutoGenerateColumns = false;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.DataGridViewProducts.DataSource = this.productBindingSource;
            this.DataGridViewProducts.Location = new System.Drawing.Point(13, 19);
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.Size = new System.Drawing.Size(442, 150);
            this.DataGridViewProducts.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceManagmentDataSetBindingSource
            // 
            this.invoiceManagmentDataSetBindingSource.DataSource = this.invoiceManagmentDataSet;
            this.invoiceManagmentDataSetBindingSource.Position = 0;
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
        private InvoiceManagmentDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.BindingSource invoiceManagmentDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}