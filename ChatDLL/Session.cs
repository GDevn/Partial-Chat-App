/**
 * FILENAME:    Session.cs
 * PURPOSE:     Class that represents the current Session of the
 *              application. Stores necessary information relating
 *              to current (and possibly past) Users of the
 *              application.
 */

using System;
using System.Collections.Concurrent;
using System.Runtime.Serialization;

namespace ChatDLL
{
    [DataContract]
    public class Session
    {
        // ### FIELDS:
        private ConcurrentDictionary<string, User> users;
        private ConcurrentDictionary<string, ChatRoom> rooms;





        // ### CONSTRUCTOR:
        public Session()
        {
            users = new ConcurrentDictionary<string, User>();
            rooms = new ConcurrentDictionary<string, ChatRoom>();
        }





        // ### ACCESSORS:
        [DataMember]
        public ConcurrentDictionary<string, User> Users 
        {
            get { return users; } 
        }


        [DataMember]
        public ConcurrentDictionary<string, ChatRoom> Chatrooms
        { 
            get { return rooms; } 
        }





        // ### METHODS:
        public bool addUser(User inUser)
        {
            return users.TryAdd(inUser.Username, inUser);
        }


        public void removeUser(User inUser)
        {
            // Don't remove 'history' of User, only de-register Callback
            User user = findUser(inUser.Username);
            user.Callback = null;
        }


        public User findUser(String inUsername)
        {
            User found;
            users.TryGetValue(inUsername, out found);
            return found;
        }

        
        public bool createChatRoom(String inChatroomName)
        {
            return rooms.TryAdd(inChatroomName, new ChatRoom(inChatroomName));
        }


        public ChatRoom findChatRoom(string inChatroomName)
        {
            ChatRoom found;
            rooms.TryGetValue(inChatroomName, out found);
            return found;
        }
    }
}
