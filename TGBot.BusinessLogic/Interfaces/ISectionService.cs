using TGBot.Common.Mapper;

namespace TGBot.BusinessLogic.Interfaces
{
    public interface ISectionService
    {
        IEnumerable<SectionDTO> Gets();
        string Title { get; }
        SectionDTO Get(string Names);
        SectionDTO DTO(string title);

        // IMapper Mapper { get; set; }
    }
}
