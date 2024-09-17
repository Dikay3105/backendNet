using System;
using System.ComponentModel.DataAnnotations;
namespace learnBackend.Models
{
    public class PartResult
    {
        public int Id { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalQuestion { get; set; }
        public int TestID { get; set; }
        public int PartID { get; set; }

        public Test Test { get; set; }
        public Part Part { get; set; }
    }
}
