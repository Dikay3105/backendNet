using System.ComponentModel.DataAnnotations;

namespace learnBackend.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int QuestionID { get; set; }
        public int SelectedAnswerID { get; set; }
        public bool IsCorrect { get; set; }

        public User User { get; set; }
        public Question Question { get; set; }
        public Answer SelectedAnswer { get; set; }
    }

}
