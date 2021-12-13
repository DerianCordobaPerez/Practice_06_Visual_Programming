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
            var products = invoiceManagementEntities.Products
                .Where(product => product.id_report == id)
                .ToList();

            products.ForEach(product => totalPrice = (product.Price * product.Quantity));
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

        public static async Task SaveReport<T>(this T form) where T : ReportsView
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

            foreach (DataGridViewRow row in form.DataGridViewNewProduct.Rows)
            {

                var name = row.Cells["Products"].Value?.ToString();

                if(name == null || string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                    continue;

                var price = invoiceEntities.Products
                    .Where(item => item.Name.Equals(name))
                    .Select(item => item.Price)
                    .FirstOrDefault();

                var newProduct = new Product
                {
                    id_report = idReport,
                    Name = name,
                    Price = price,
                    Quantity = int.Parse(row.Cells["Quantity"].Value?.ToString() ?? "1")
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
            ClearControls(form);
        }

        private static void ClearControls(ReportsView form)
        {
            form.TextBoxClient.Clear();
            form.TextBoxReportCode.Clear();
        }
    }
}
