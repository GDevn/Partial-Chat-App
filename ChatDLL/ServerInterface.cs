/**
 * FILENAME:    ServerInterface.cs
 * PURPOSE:     Contains two interfaces to by implemented by Server and Callback.
 */

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ServiceModel;

namespace ChatDLL
{
    /**
     * Interface to be implemented by ServerOImplementation.cs
     */
    [ServiceContract (CallbackContract = typeof(ServerCallback)) ]
    public interface ServerInterface
    {
        // ### User Management
        [OperationContract]
        void AddClient(string username);

        [OperationContract]
        void RemoveClient(string username);

        [OperationContract]
        int GetNumUsers();

        [OperationContract]
        bool IsValidLogin(string username);

        


        // ### Message Management
        [OperationContract (IsOneWay = true) ]
        void BroadcastMessage(Message message);

        



        // ### ChatRoom Management
        [OperationContract]
        void CreateChatroom(string chatroomName);

        [OperationContract (IsOneWay = true) ]
        void JoinChatroom(string username, string chatroomName);

        [OperationContract]
        void UpdateChatroomListGUI();

        
        [OperationContract]
        List<ChatRoom> GetChatRooms(string key);
    }





    /**
     * Implemented by ServerCallbackImplementation.cs
     */
    public interface ServerCallback
    {
        [OperationContract (IsOneWay = true) ]
        void DisplayMessages(string chatroomName, List<Message> chatroom);

        [OperationContract(IsOneWay = true)]
        void DisplayChatrooms(List<string> rooms);
    }
}
