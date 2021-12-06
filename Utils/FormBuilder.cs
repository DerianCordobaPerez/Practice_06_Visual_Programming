﻿using System;
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

        private static SignInController signInController = new SignInController();
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
                var response = MessageBox.Show("Are you sure you want to exit?",
                "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                    Application.Exit();

                e.Cancel = true;
            }
        }

        public static void SignInForm<T>(this T form) where T : SignInView
        {
            string username = form.TextBoxUserName.Text;
            string password = form.TextBoxPassword.Text;
            var user = signInController.SignIn(username, password);

            if (user != null)
            {
                MessageBox.Show("Session successfully started");
                UserContext.GetInstance().SetUser(user);
                form.Dispose();
                return;
            }

            MessageBox.Show("The username or password is incorrect");
        }

        public static void ShowHideLabel<T>(this T form, object sender, Label label, int minimum) where T : Form
        {
            if(((TextBox)sender).Text.Length < minimum)
                label.Show();
            else
                label.Hide();
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
