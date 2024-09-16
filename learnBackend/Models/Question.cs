using System;
using System.ComponentModel.DataAnnotations;

namespace learnBackend.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int PartID { get; set; }

        [Required]
        public string Text { get; set; }

        public string? ImagePath { get; set; } // Thay đổi từ string thành string?

        public string? AudioPath { get; set; } // Thay đổi từ string thành string?

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int AnswerCounts { get; set; }
    }
}
