using Newtonsoft.Json;
using OpenAI.ApiClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI.ResponseObjects
{
    [Serializable]
    public class AskQuestionResponse: BaseResponse
    {
        /// <summary>
        /// The list of choices that the user was presented with during the chat interaction
        /// </summary>
        [DataMember(Name = "choices")]
        public IReadOnlyList<ResponseChoice> Choices { get; set; }

    }

}
