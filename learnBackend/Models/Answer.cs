using System;
using System.ComponentModel.DataAnnotations;
namespace learnBackend.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
    }
}


