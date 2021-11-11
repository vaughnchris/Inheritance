using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Value { get; set; }
        public string GradingRubric { get; set; }
        public string MoreInfo { get; set; }
        public string OutcomeMapping { get; set; }
        public string Explanation { get; set; }
    }
    public class MultipleChoiceQuestion:Question
    {
        public List<Dictionary<char, string>> Choices { get; set;} = new List<Dictionary<char, string>>();
        public List<Dictionary<char,string>> Answers { get; set; } = new List<Dictionary<char, string>>();
        public MultipleChoiceQuestion() { }
        public MultipleChoiceQuestion(List<Dictionary<char,string>> choices, List<Dictionary<char,string>> answers)
        {
            Choices = choices;
            Answers = answers;
        }
    }
    public class WrittenAnswerQuestion:Question
    {
        public string Answer { get; set; } = String.Empty;
        public WrittenAnswerQuestion(string answer)
        {
            Answer = answer;
        }
    }
    public class TrueFalseQuestion:Question
    {
        public bool Answer { get; set; }
       public TrueFalseQuestion(bool answer)
        {
            Answer=answer;
        }
    }
}
