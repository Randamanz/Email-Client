﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_Email_Client;

namespace The_Email_Client
{
    /// <summary>
    /// Interaction logic for ForgottonPasswordPage.xaml
    /// </summary>
    public partial class ForgottonPasswordPage : Page
    {
        public static int ResetCode { get; set; }
        protected Action ShowenterResetCodePage { get; set; }
        public ForgottonPasswordPage(Action ShowenterResetCodePage)
        {
            InitializeComponent();
            this.ShowenterResetCodePage = ShowenterResetCodePage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Hashing.VerifyHash(UserNameTextBox.Text,EmailTextBox.Text,0))
            {
                Random rnd = new Random();
                ResetCode = rnd.Next(10000000, 99999999);
                string[] emails = new string[1]; emails[0] = EmailTextBox.Text;
                try
                {
                    Email tempemail = new Email()
                    {
                        Server = "smtp.gmail.com",
                        Port = 587,
                        UserEmail = "testofcsharperinoemailerino@gmail.com",
                        UserPassword = "nocopypasterino",
                        UserName = "Email Client Reset Password",
                        Recipients = emails,
                        CC = null,
                        BCC = null,
                        Subject = "Reset Password Request",
                        Body = "Somebody has Requested a Password Reset for this email.\nIf this was not you please ignore this email.\n" +
                        $"If this was you your email reset code is as follows: {ResetCode}.\nPlease copy this code down this code, " + 
                        "return to the email client and follow the on screen instructions.",
                        AttachmentNames = null
                    };
                    new Thread(new ParameterizedThreadStart(delegate { tempemail.Send(); })) { IsBackground = true }.Start();
                    ShowenterResetCodePage();
                }
                catch (Exception error)
                {
                    System.Windows.Forms.MessageBox.Show(error.Message);
                }
            }
        }
    }
}
