/**
 * FILENAME:    ServerImplementation.cs
 * PURPOSE:     Implements ServerInterface. Represents the business-side of application.
 */

using ChatDLL;

using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ChatServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    internal class ServerImplementation : ServerInterface
    {
        // ### FIELDS:

        // Keeps track of the current Session, only one instance throughout lifetime of Server.
        private static Session session = new Session();





        // ### IMPLEMENTED METHODS:

        /**
         * To add Client to Server for tracking.
         */
        public void AddClient(string username)
        {
            // Logic here.
        }


        /**
         * To remove Client connection to Server.
         */
        public void RemoveClient(string username)
        {
            // Logic here.
        }


        /**
         * To get the number of Users in the Server.
         */ 
        public int GetNumUsers()
        {
            return session.Users.Count;
        }


        /**
         * To iterate through User list and see if username already exists, returns bool.
         */
        public bool IsValidLogin(string username)
        {
            // Logic here.
        }


        /**
         * Receives a Message object, will handle the broadcast of message
         * according to what Chatroom the Sender was in.
         */
        public void BroadcastMessage(Message message)
        {
            // Logic here.
        }


        /**
         * To create a Chatroom if name is not already taken.
         */
        public void CreateChatroom(string chatroomName)
        {
            // Logic here.
        }


        /**
         * To add User to ChatRoom.
         */
        public void JoinChatroom(string username, string chatroomName)
        {
            // Logic here.
        }


        /**
         * To update ChatRoom panel for all Users.
         */
        public void UpdateChatroomListGUI()
        {
            // Logic here.
        }
        

        
        public List<ChatRoom> GetChatRooms(string key)
        {
            // Logic here.
        }
        





        // ### HELPER METHODS:

        /**
         * Helper method for BroadcastMessage(). 
         * To simply parse message and detect if '/p' keyword is in message.
         */
        private void parseMessage(Message message)
        {
            // Logic here.
        }
    }
}
