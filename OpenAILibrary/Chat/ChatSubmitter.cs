using OpenAI.RequestObjects;
using OpenAI.ResponseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace OpenAI.Chat
{
    public class ChatSubmitter
    {
        private readonly string openai_key = "sk-";
       
        public ChatSubmitter()
        {
        }

        public AskQuestionResponse AskQuestion(AskQuestionRequest question)
        {
            var response = new AskQuestionResponse() { IsSuccessful = false};

            var postData = Newtonsoft.Json.JsonConvert.SerializeObject(question);

            var webResponse = DoWebRequest("https://api.openai.com/v1/chat/completions", Method.POST, openai_key, postData);

            if (webResponse.IsSuccessful)
            {
                response.IsSuccessful = true;
                response = Newtonsoft.Json.JsonConvert.DeserializeObject<AskQuestionResponse>(webResponse.Content);
                return response;
            }
            response.IsSuccessful = false;
            return response;
        }

        private IRestResponse DoWebRequest(string url, RestSharp.Method method, string access_token, string PostData)
        {
            // disable SSL cerrtificate validation
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            IRestResponse response = new RestResponse();

            // Instantiate a POST RestRequest
            RestRequest request = new RestRequest(method);

            // Creates a new RestClient instance with the specified URL
            RestClient client = new RestClient(url);

            // Add the OpenAI secret to the header
            request.AddHeader("Authorization", "Bearer " + access_token);

            // add the PostData to the request as JSON data
            request.AddJsonBody(PostData);

            return client.Execute(request);
        }
    }
}
