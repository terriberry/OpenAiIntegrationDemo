using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI.ApiClasses
{
    [Serializable]
    public class ResponseChoiceMessage
    {
        [DataMember(Name = "content")]
        public string Content { get; set; }
    }
}
