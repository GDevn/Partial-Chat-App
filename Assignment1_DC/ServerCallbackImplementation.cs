/**
 * FILENAME:    ServerCallbackImplementation.cs
 * PURPOSE:     Implements ServerCallback. Allows Server to asynchronously
 *              notify/send data back to the Client.
 */

using ChatDLL;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ServiceModel;


namespace Assignment1_DC
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    internal class ServerCallbackImplementation : ServerCallback
    {
        // ### FIELDS:
        private MainWindow window; // To have access to MainWindow





        // ### CONSTRUCTOR:
        public ServerCallbackImplementation(MainWindow window)
        {
            this.window = window;
        }





        // ## IMPLEMENTED METHODS:

        /**
         * To call UpdateMessages() method in MainWindow.
         */
        public void DisplayMessages(string chatroomName, List<Message> chatLog)
        {
            window.UpdateMessages(chatroomName, chatLog);
        }

        /**
         * To call UpdateChatrooms() method in MainWindow().
         */
        public void DisplayChatrooms(List<string> rooms)
        {
            window.UpdateChatrooms(rooms);
        }
    }
}
