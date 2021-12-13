using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_06.Views;

namespace Practice_06.Utils
{
    public static class ReportsViewBuilder
    {
        public static T ConfigurationComboBoxCodes<T>(this T form) where T : ReportsView
        {
            InvoiceManagementEntities invoiceManagementEntities = new InvoiceManagementEntities();
            var values = invoiceManagementEntities.Reports.Select(item => item.Id).ToList();
            values.ForEach(item => form.ComboBoxReportsCode.Items.Add(item));
            form.ComboBoxReportsCode.SelectedIndex = 0;
            return form;
        }

        public static T ConfigurationDataGridViewProducts<T>(this T form) where T : ReportsView
        {
            InvoiceManagementEntities invoiceManagementEntities = new InvoiceManagementEntities();
            var values = invoiceManagementEntities.Products.Select(item => item.Name).ToList();
            values.ForEach(item => form.Products.Items.Add(item));

            return form;
        }

        public static T ConfigurationDataGridView<T>(this T form) where T : ReportsView
        {
            InvoiceManagementEntities invoiceManagementEntities = new InvoiceManagementEntities();
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var products = invoiceManagementEntities.Products.Where(i => i.id_report == id).ToList();
            form.DataGridViewProducts.DataSource = products;
            return form;
        }

        public static T ChangeTotalPrice<T>(this T form) where T : ReportsView
        {
            InvoiceManagementEntities invoiceManagementEntities = new InvoiceManagementEntities();
            var totalPrice = 0.0;
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var prices = invoiceManagementEntities.Products
                .Where(product => product.id_report == id)
                .Select(product => product.Price)
                .ToList();

            prices.ForEach(price => totalPrice += price);
            form.TextBoxTotal.Text = $@"{totalPrice}";
            return form;
        }

        public static T ChangeCliente<T>(this T form) where T : ReportsView
        {
            InvoiceManagementEntities invoiceManagementEntities = new InvoiceManagementEntities();
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var report = invoiceManagementEntities.Reports.Where(item => item.Id == id);
            var client = report.Select(item => item.Client).FirstOrDefault();
            var date = report.Select(item => item.Date).FirstOrDefault();

            form.TextBoxInfoUser.Text = $"Client: {client}\r\nDate: {date}";

            return form;
        }

        public static async void SaveReport<T>(this T form) where T : ReportsView
        {
            var invoiceEntities = new InvoiceManagementEntities();
            var reports = invoiceEntities.Reports;
            var id = form.TextBoxReportCode.Text;
            var client = form.TextBoxClient.Text;


            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(client))
            {
                MessageBox.Show(@"All fields required");
                return;
            }

            var idReport = int.Parse(id);
            var exists = reports.Where(item => item.Id == idReport).FirstOrDefault();

            if (exists != null)
            {
                MessageBox.Show(@"The ID entered already exists in another record");
                return;
            }

            var productHashSet = new HashSet<Product>();
            var rows = form.DataGridViewNewProduct.RowCount - 1;

            for(int i = 0; i < rows; ++i)
            {
                var name = form.DataGridViewNewProduct.Rows[i].Cells["Products"].Value.ToString();
                var price = invoiceEntities.Products
                    .Where(item => item.Name.Equals(name))
                    .Select(item => item.Price)
                    .FirstOrDefault();

                var newProduct = new Product
                {
                    id_report = idReport,
                    Name = name,
                    Price = price,
                    Quantity = int.Parse(form.DataGridViewNewProduct.Rows[i].Cells["Quantity"].Value.ToString())
                };
                
                productHashSet.Add(newProduct);
                invoiceEntities.Products.Add(newProduct);
            }

            var report = new Report
            {
                Id = int.Parse(id),
                Client = form.TextBoxClient.Text,
                Date = form.DateTimePickerPurchase.Text,
                Products = productHashSet
            };

            reports.Add(report);
            await invoiceEntities.SaveChangesAsync();
            MessageBox.Show("Report saved successfully");
        }

        private static List<TextBox> GetTextBoxs(ReportsView form)
        {
            return form.Controls.OfType<TextBox>()
                .Where(textbox => textbox.Name.StartsWith("_"))
                .Select(textbox => textbox)
                .ToList();
        }

        private static bool VerifyInfoReport(ReportsView form)
        {
            var textboxs = GetTextBoxs(form);
            return textboxs.All(textbox => string.IsNullOrWhiteSpace(textbox.Text));
        }
    }
}
