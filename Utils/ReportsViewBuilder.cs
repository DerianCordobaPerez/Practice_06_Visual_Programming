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

        public static void SaveReport<T>(this T form) where T : ReportsView
        {
            var reports = new InvoiceManagementEntities().Reports;
            var count = reports.Count();

            if (!VerifyInfoReport(form))
            {
                MessageBox.Show(@"All fields required");
                return;
            }

            var report = new Report
            {
                Id = ++count,
                Client = form.TextBoxClient.Text,
                Date = form.DateTimePickerPurchase.Text,
            };

            //pending
        }

        private static List<TextBox> GetTextBoxs(Form form)
        {
            return form.Controls.OfType<TextBox>()
                .Where(textbox => textbox.Name.Contains("TextBox"))
                .ToList();
        }

        private static bool VerifyInfoReport(ReportsView form)
        {
            var textboxs = GetTextBoxs(form);
            return textboxs.All(textbox => string.IsNullOrWhiteSpace(textbox.Text));
        }
    }
}
