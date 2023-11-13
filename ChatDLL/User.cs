/**
 * FILENAME:    User.cs
 * PURPOSE:     Class that represents the User in the application.
 *              Stores necessary information relating to the class.
 */

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ChatDLL
{
    [DataContract]
    public class User
    {
        // ### FIELDS:
        private string username;
        private ServerCallback callback;
        private string chatRoom;





        // ### CONSTRUCTOR:
        public User(string inUsername, ServerCallback inCallback)
        {
            username = inUsername;
            callback = inCallback;

            chatRoom = null;                // Keep track of ChatRoom Name
        }





        // ### ACCESSORS and MUTATORS:
        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        [DataMember]
        public string ChatRoom
        {
            get { return chatRoom; }
            set { chatRoom = value; }
        }


        [DataMember]
        public ServerCallback Callback
        {
            get { return callback; }
            set { callback = value; }
        }
    }
}
