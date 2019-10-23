using Mitrais_Test_Core.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.Model
{
    public class Messages
    {
        private int code;
        private Dictionary<string, string> message;

        public Messages(int code, params MessageContent[] _message)
        {
            this.code = code;
            this.message = new Dictionary<string, string>();
            foreach (MessageContent msg in _message)
            {
                message.Add(msg.Language, msg.Content);
            }
        }

        public string Message
        {
            get
            {
                return message[SessionHelper.Info.Language];
            }
        }

        public int Code
        {
            get
            {
                return this.code;
            }
        }
    }
}
