using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_06.Controllers;
using Practice_06.Views;

namespace Practice_06.Utils
{
    public static class FormBuilder
    {
        private static UserContext UserContext = UserContext.GetInstance();

        public static void InitialConfiguration<T>(this T form) where T : Form1
        {
            if (UserContext.IsLoggedIn())
            {
                var user = UserContext.GetUser();
                form.ToolStripStatusLabelUser.Text = $@"User: {user.Name}";
                form.Text = $@"Welcome {user.UserName} Active since {DateTime.Now}";
            }
        }

        public static void ShowForm<T>(this T form, Form children, bool isMdi = true) where T : Form
        {
            if (!IsOpen(children.Name))
            {
                if(!isMdi)
                {
                    children.ShowDialog();
                    return;
                }
                children.MdiParent = form;
                children.Show();
            }
        }

        public static void ClosingForm<T>(this T form, FormClosingEventArgs e) where T : Form
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var response = MessageBox.Show(@"Are you sure you want to exit?",
                @"Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                    Application.Exit();

                e.Cancel = true;
            }
        }

        public static void CascadeForm<T>(this T form) where T : Form1
        {
            form.LayoutMdi(MdiLayout.Cascade);
        }

        public static void HorizontalForm<T>(this T form) where T : Form1
        {
            form.LayoutMdi(MdiLayout.TileHorizontal);
        }

        public static void VerticalForm<T>(this T form) where T : Form1
        {
            form.LayoutMdi(MdiLayout.TileVertical);
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
