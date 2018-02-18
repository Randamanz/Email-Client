﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace The_Email_Client {
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page {

        protected Action ShowLoginPage { get; set; }

        public RegistrationPage(Action ShowLoginPage) {
            InitializeComponent();
            this.ShowLoginPage = ShowLoginPage;

            KeyDown += delegate {
                if (Keyboard.IsKeyDown(Key.Enter)) {
                    if (UserNameAlreadyExists(UserNameTextBox.Text) && PasswordsMatch() && NonNullFields())
                        RegisterUser();
                 }
            };
        }
        
        private void SignUpbutton_Click(object sender, RoutedEventArgs e) {
            if (Common.Inccorectemailformat(EmailTextBox.Text)
                && UserNameAlreadyExists(UserNameTextBox.Text) 
                && NonNullFields()
                && PasswordsMatch())
                RegisterUser();
        }

        private bool NonNullFields() {
            if (!string.IsNullOrWhiteSpace(EmailTextBox.Text) 
                && !string.IsNullOrWhiteSpace(NameTextBox.Text)
                && !string.IsNullOrWhiteSpace(UserNameTextBox.Text)
                && !string.IsNullOrWhiteSpace(Passwordbox.Password)
                ) return true;
            else {
                MessageBox.Show("No fields can be left empty.","Error!");
                return false; }
        }//make email optional

        private bool UserNameAlreadyExists(string UserName) {
            OleDbConnection cnctDTB = new OleDbConnection(Constants.DBCONNSTRING);
            try {
                cnctDTB.Open();
                OleDbCommand cmd = new OleDbCommand($"SELECT UserName FROM Profiles WHERE [UserName]='{UserName}'", cnctDTB);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) if (reader.HasRows) {
                        MessageBox.Show("UserName Already Exists!", "Error!");
                        return false;
                    }
            }
            catch (Exception err) { System.Windows.MessageBox.Show(err.Message); }
            finally { cnctDTB.Close(); }
            return true;
        }
        
        private bool PasswordsMatch() {
            if (Passwordbox.Password == PasswordboxCopy.Password) return true;
            else {
                MessageBox.Show("Passwords do not Match!", "Error");
                return false;
            }
        }
       
        private void RegisterUser() {
            OleDbConnection cnctDTB = new OleDbConnection(Constants.DBCONNSTRING);
            try {
                cnctDTB.Open();
                OleDbCommand cmd = new OleDbCommand($"INSERT INTO Profiles ([Name],[UserName],[Password],[Email],[Settings_ID]) " + 
                    $"VALUES ('{NameTextBox.Text}','{UserNameTextBox.Text}','{Encryption.HashString(Passwordbox.Password)}',"+
                    $"'{Encryption.HashString(EmailTextBox.Text)}', 1);", cnctDTB);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Successfully registered account.", "Success!");
                EmailTextBox.Clear(); NameTextBox.Clear();
                ShowLoginPage?.Invoke();
            }
            catch (Exception err) {
                MessageBox.Show("Failed to registered account.", "Error!");
                System.Windows.MessageBox.Show(err.Message);
            }
            finally { cnctDTB.Close(); }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            EmailTextBox.Clear(); NameTextBox.Clear();
            ShowLoginPage?.Invoke();
        }
    }






    
}
