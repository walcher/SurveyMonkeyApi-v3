using SurveyMonkey.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyMonkey.RequestSettings
{
    public class CreateSurveySettings
    {
        public string Title { get; set; }
        public string FromTemplateId { get; set; }
        public string FromSurveyId { get; set; }
        public string Nickname { get; set; }
        public string Language { get; set; }
        public ButtonsText ButtonsText { get; set; }
        public Dictionary<string, string> CustomVariables { get; set; }
        public bool Footer { get; set; }
        public string FolderId { get; set; }
        public QuizOptions QuizOptions { get; set; }
        public List<Page> Pages { get; set; }
    }
}
