using System;
using System.ComponentModel.DataAnnotations;
namespace learnBackend.Models
{
    public class History
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int TestID { get; set; }
        public int TotalListening { get; set; }
        public int TotalReading { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public User User { get; set; }
        public Test Test { get; set; }
    }
}