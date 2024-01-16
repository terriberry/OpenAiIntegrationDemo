using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenAI.ApiClasses;

namespace OpenAI.RequestObjects
{
    public class AskQuestionRequest
    {
        /// <summary>
        /// The messages to send with this Chat Request
        /// </summary>
        [JsonProperty("messages")]
        public IList<RequestMessages> Messages { get; set; }

        /// <summary>
        /// The model to be used
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; } = "gpt-3.5-turbo";

        public AskQuestionRequest(string _model, string _message)
        {
            Model = _model;
            Messages = new List<RequestMessages>();
            Messages.Add(new RequestMessages("system", "You are an expert in the medical field. Make a summary of the user input in 200 words."));
            Messages.Add(new RequestMessages("user", _message));
        }

        public AskQuestionRequest(string _message)
        {
            Messages = new List<RequestMessages>();
            Messages.Add(new RequestMessages("system", "You are an expert in the medical field. Make a summary of the user input in 200 words."));
            Messages.Add(new RequestMessages("user", _message));
        }

    }
}
