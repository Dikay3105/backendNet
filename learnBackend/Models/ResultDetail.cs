using System;
using System.ComponentModel.DataAnnotations;
namespace learnBackend.Models
{
    public class ResultDetail
    {
        public int Id { get; set; }
        public int PartID { get; set; }
        public int HistoryID { get; set; }

        public Part Part { get; set; }
        public History History { get; set; }
    }
}
