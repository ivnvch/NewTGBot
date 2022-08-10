
namespace TGBot.Models
{
    public class Teacher
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string MobilePhone { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}

