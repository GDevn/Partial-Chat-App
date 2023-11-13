/**
 * FILENAME:    LoginPage.xaml.cs
 * PURPOSE:     Represents the login page of the application. Deals with User login
 *              authentication.
 */

using ChatDLL;

using System.Windows;
using System.ServiceModel;
using System;

namespace Assignment1_DC.View
{
    public partial class LoginPage : Window
    {
        // ### FIELDS:
        private ServerInterface foob;
        private ServerCallback foobCallback;
        private DuplexChannelFactory<ServerInterface> foobFactory;





        // ### CONSTRUCTOR:
        public LoginPage()
        {
            // Logic here.
        }





        // ### METHODS:

        /**
         * [On-Click-Listener]
         * To verify if username is free and proceed to MainWindow.
         */
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /*
         * To handle the closing of the login window once authentication is done.
         */
        private void closeWindow()
        {
           // Logic here.
        }
    }
}