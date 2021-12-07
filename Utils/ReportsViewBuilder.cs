﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_06.Views;

namespace Practice_06.Utils
{
    public static class ReportsViewBuilder
    {
        private static InvoiceManagementEntities InvoiceManagementEntities = new InvoiceManagementEntities();

        public static T ConfigurationComboBoxCodes<T>(this T form) where T : ReportsView
        {
            var values = InvoiceManagementEntities.Reports.Select(item => item.Id).ToList();
            values.ForEach(item => form.ComboBoxReportsCode.Items.Add(item));
            form.ComboBoxReportsCode.SelectedIndex = 0;
            return form;
        }

        public static T ConfigurationDataGridView<T>(this T form) where T : ReportsView
        {
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var products = InvoiceManagementEntities.Products.Where(i => i.id_report == id).ToList();
            form.DataGridViewProducts.DataSource = products;
            return form;
        }

        public static T ChangeTotalPrice<T>(this T form) where T : ReportsView
        {
            var totalPrice = 0.0;
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var prices = InvoiceManagementEntities.Products
                .Where(product => product.id_report == id)
                .Select(product => product.Price)
                .ToList();

            prices.ForEach(price => totalPrice += price);
            form.TextBoxTotal.Text = $@"{totalPrice}";
            return form;
        }

        public static T ChangeCliente<T>(this T form) where T : ReportsView
        {
            var id = int.Parse(form.ComboBoxReportsCode.Text);
            var report = InvoiceManagementEntities.Reports.Where(item => item.Id == id);
            var client = report.Select(item => item.Client).FirstOrDefault();
            var date = report.Select(item => item.Date).FirstOrDefault();

            form.TextBoxInfoUser.Text = $"Client: {client}\r\nDate: {date}";

            return form;
        }
    }
}
