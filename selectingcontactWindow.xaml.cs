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
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;


namespace The_Email_Client
{
    /// <summary>
    /// Interaction logic for ContactsManagerWindows.xaml
    /// </summary>
    /// 
    
    public partial class selectingcontactWindow : Window
    {

        List<string> emaillist = new List<string>();
        public Contacts[] SelectedContacts { get; protected set; }
        public Contacts[] preexistingcontacts;

        public selectingcontactWindow(Contacts[] contacts)
        {
            InitializeComponent();
            SelectedContacts = new Contacts[0];
            this.preexistingcontacts = contacts;
            updatetable();
        }




        public void updatetable()
        {
            OleDbConnection cnctDTB = new OleDbConnection(Constants.DBCONNSTRING);
            
            try
            {
                cnctDTB.Open();
                string InsertSql = "SELECT * FROM Adresses";
                OleDbCommand cmdInsert = new OleDbCommand(InsertSql, cnctDTB);
                OleDbDataReader reader = cmdInsert.ExecuteReader();

                contactsDataGrid.Items.Clear();
                emaillist.Clear();
                bool includecontact = true;
                while (reader.Read())
                {
                    includecontact = true;
                    foreach (var contact in preexistingcontacts)
                    {
                        if (contact.EmailAddress == Common.Cleanstr((string)reader[2]))
                        {
                            includecontact = false;
                        }
                    }
                    if (includecontact)
                    {
                        contactsDataGrid.Items.Add(new Contacts { Name = Common.Cleanstr((string)reader[1]), EmailAddress = Common.Cleanstr((string)reader[2]) });
                        emaillist.Add(Common.Cleanstr((string)reader[2]));
                    }
                }
            }
            catch (Exception err)
            {
                
                System.Windows.MessageBox.Show(err.Message);
            }
            finally
            {
                cnctDTB.Close();
            }
        }

        private void addcontacttoemailButton_Click(object sender, RoutedEventArgs e)
        {
            List<Contacts> contacts = new List<Contacts>();
            foreach(Contacts contact in contactsDataGrid.SelectedItems)
            {
                contacts.Add(contact);
            }
            SelectedContacts = contacts.ToArray();
            Close();
        }
    }
}