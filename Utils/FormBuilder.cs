using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_06.Utils
{
    public static class FormBuilder
    {
        /// <summary>
        /// Displays the form natively for classes that implement the Form class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="form"></param>
        /// <param name="children"></param>
        /// <param name="isMdi"></param>
        public static void ShowForm<T>(this T form, Form children, bool isMdi = true) where T : Form
        {
            if (!IsOpen(children.Name))
            {
                if(isMdi)
                {
                    children.MdiParent = form;
                    children.Show();
                    return;
                }
                children.ShowDialog();
            }
        }

        public static void ClosingForm<T>(this T form, FormClosingEventArgs e) where T : Form
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var response = MessageBox.Show("Are you sure you want to exit?",
                "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                    Application.Exit();

                e.Cancel = true;
            }
        }

        private static bool IsOpen(string name)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.CompareTo(name) == 0)
                    return true;
            }
            return false;
        }
    }
}
