/**
 * FILENAME:    Message.cs
 * PURPOSE:     Represents a message in the application. Stores information of
 *              sender and comment.
 */

using System.Runtime.Serialization;

namespace ChatDLL
{
    [DataContract]
    public class Message
    {
        // ### FIELDS:  
        private string user;
        private string comment;

        private bool isPrivate;
        private string target;





        // ### CONSTRUCTOR:
        public Message(string inUser, string inComment)
        {
            user = inUser;
            comment = inComment;
            isPrivate = false;
            target = null;
        }





        // ### ACCESSORS and MUTATORS:
        [DataMember]
        public string User
        { 
            get { return user; }
            set { user = value; } 
        }


        [DataMember]
        public string Comment 
        { 
            get { return comment; } 
            set { comment = value; } 
        }


        [DataMember]
        public bool IsPrivate
        {
            get { return isPrivate; }
            set { isPrivate = value; }
        }


        [DataMember]
        public string Target
        { 
            get { return target; } 
            set {  target = value; } 
        }
    }
}
