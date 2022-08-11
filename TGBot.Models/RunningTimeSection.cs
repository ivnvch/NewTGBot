using System.ComponentModel.DataAnnotations;

namespace TGBot.Models
{
    public class RunningTimeSection
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DayOfWeek { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }

    }
}
