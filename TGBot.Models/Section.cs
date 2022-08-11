namespace TGBot.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string RunningTime { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<RunningTimeSection> RunningSections { get; set; }
    }
}
