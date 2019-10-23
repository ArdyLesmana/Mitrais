using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.Model
{
    public class MessageContent
    {
        public string Language { get; set; }
        public string Content { get; set; }

        public MessageContent(string _lang, string _content)
        {
            Language = _lang;
            Content = _content;
        }
    }
}
