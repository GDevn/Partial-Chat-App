/**
 * FILENAME:    ChatRoom.cs
 * PURPOSE:     Represents a Chat Room. 
 *              Keeps track of the Name of chatroom, Users in chatroom and Chatlog.
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ChatDLL
{
    [DataContract]
    public class ChatRoom
    {
        // ### FIELDS:
        private string name;
        private ConcurrentDictionary<string, User> users;
        private List<Message> chatLog;





        // ### CONSTRUCTOR:
        public ChatRoom(string inName)
        {
            name = inName;
            users = new ConcurrentDictionary<string, User>();
            chatLog = new List<Message>();
        }





        // ### ACCESSORS and MUTATORS:
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        [DataMember]
        public ConcurrentDictionary<string, User> Users
        {
            get { return users; }
            set { users = value; }
        }


        [DataMember]
        public List<Message> ChatLog
        {
            get { return chatLog; }
            set { chatLog = value; }
        }





        // ### METHODS:
        public bool AddUser(User user)
        {
            return users.TryAdd(user.Username, user);
        }


        public bool RemoveUser(User user)
        {
            return users.TryRemove(user.Username, out user);
        }


        public void AddMessage(Message message)
        {
            chatLog.Add(message);
        }
    }
}
