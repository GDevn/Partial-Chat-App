/**
 * FILENAME:    MainWindow.xaml.cs
 * PURPOSE:     Represents the main window of the application. Deals with the
 *              calling of local and remote methods which make up the functionality of the
 *              application.
 */

using ChatDLL;

using System.Windows;
using System.ServiceModel;
using System.Collections.Generic;
using System;
using Microsoft.Win32;
using System.IO;
using System.Windows.Controls;
using System.Collections.Concurrent;
using System.Linq;
using System.Windows.Input;

namespace Assignment1_DC
{
    public partial class MainWindow : Window
    {
        // ### FIELDS:

        private ServerInterface foob;
        private DuplexChannelFactory<ServerInterface> foobFactory;
        private ServerCallback foobCallback;
        private string username;





        // ### CONSTRUCTOR:

        public MainWindow()
        {
            // Logic here.
        }





        // ### METHODS:

        /**
         * Called by LoginView window to:
         *      - Add User to Server's Session
         *      - Update Chatroom GUI if Session exists already
         */
        public void setUser(string inUsername)
        {
            // Logic here.
        }


        /**
         * [On-Click-Listener]
         * To create a chatroom from a given chatroom name.
         */
        private void CreateChatroomButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /**
         * [On-Click-Listener]
         * To send a message to the ChatRoom.
         */
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        private void ChatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
                {
                    SendButton_Click(sender, e);
                    e.Handled = true;
                }
            }
        }


        /**
         * [On-Click-Listener]
         * To share file to ChatRoom.
         */
        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /**
         * [On-Click-Listener]
         * To allow User to logout from Server.
         */
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /**
         * [On-Click-Listener]
         * To download file in ChatRoom.
         */
        private void Message_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /**
         * [On-Click-Listener]
         * To join ChatRoom and update GUI accordingly.
         */
        private void ChatRoom_Click(object sender, RoutedEventArgs e)
        {
            // Logic here.
        }


        /**
         * [Called by Callback Method]
         * To update the Client's Chat GUI.
         */
        public void UpdateMessages(string chatroomName, List<Message> chatLog)
        {
            // To update UI, execute on UI thread
            ChatListView.Dispatcher.Invoke(() =>
            {
                // Logic here.
            });
        }


        /**
         * [Called by Callback Method]
         * To update Client's ChatRoomList GUI.
         */
        public void UpdateChatrooms(List<string> chatrooms)
        {
            ChatRoomListView.Dispatcher.Invoke(() =>
            {
                // Logic here.
            });
        }


        /**
         * To handle the closing of the window once User has logged out.
         */
        private void closeWindow()
        {
            // Logic here.
        }
    }
}
