using TGBot.Common.Mapper;

namespace TGBot.BusinessLogic.Interfaces
{
    public interface ITeacherService
    {
        IEnumerable<TeacherDTO> Gets();
        TeacherDTO Get(int id);
        TeacherDTO TeacherDTO();
        //IMapper Mapper { get; set; }
    }
}
