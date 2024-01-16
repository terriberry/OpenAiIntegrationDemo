using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenAI.ApiClasses
{
    public class RequestMessages
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        public RequestMessages(string _role, string _content) 
        {
            Role = _role;
            Content = _content;
        }

    }
}
