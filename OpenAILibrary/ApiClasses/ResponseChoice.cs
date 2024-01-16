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
    public class ResponseChoice
    {
        /// <summary>
        /// The message that was presented to the user as the choice
        /// </summary>
        [DataMember(Name = "message")]
        public ResponseChoiceMessage Message { get; set; }
    }

}
