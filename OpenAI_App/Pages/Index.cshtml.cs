using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenAI.Chat;
using OpenAI.RequestObjects;
using OpenAI.ResponseObjects;
using OpenAILibrary;

namespace OpenAI_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        
        public void OnPost()
        {
            var chatSubmitter = new ChatSubmitter();
            AskQuestionRequest askQuestionRequest = new AskQuestionRequest(Request.Form["user_input"]);
            AskQuestionResponse response = chatSubmitter.AskQuestion(askQuestionRequest);
            ViewData["ai_message"] = response.Choices[0].Message.Content;
        }
    }
}
