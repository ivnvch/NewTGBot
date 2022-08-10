using TGBot.Models;

namespace TGBot.BusinessLogic.Interfaces
{
    public interface ITeacherBySectionService
    {
        IEnumerable<TeacherBySection> Gets(string name);
    }
}
