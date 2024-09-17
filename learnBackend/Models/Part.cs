using learnBackend.Models;
using static System.Net.Mime.MediaTypeNames;

public class Part
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Number { get; set; }
    public string Description { get; set; } = string.Empty;
    public int TestID { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public Test Test { get; set; }
    public ICollection<Question> Questions { get; set; }
}
