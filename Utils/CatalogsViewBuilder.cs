using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_06.Views;

namespace Practice_06.Utils
{
    public static class CatalogsViewBuilder
    {
        public static void FillDataSet<T>(this T form) where T : CatalogsView
        {
            form.productTableAdapter.Fill(form.invoiceManagmentDataSet.Product);
        }

        public static void HasChangesDataSet<T>(this T form) where T : CatalogsView
        {
            if (form.invoiceManagmentDataSet.HasChanges())
            {
                var productDataSet = form.invoiceManagmentDataSet.Product;
                form.productTableAdapter.Update(productDataSet);
            }
        }

    }
}
