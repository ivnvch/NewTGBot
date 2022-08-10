using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TGBot.BusinessLogic.Interfaces;
using TGBot.Common.Mapper;
using TGBot.Models;

namespace TGBot.BusinessLogic.Implementations
{
    public class SectionService : ISectionService
    {
        DataContext _context;
        IMapper _mapper;

        public SectionService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public string Title { get;}

        public  SectionDTO DTO(string title)
        {
            Section section = new Section();
            using (DataContext context = new DataContext())
            {
                //var userProfiles = _db.UserProfiles.Include(c => c.UserGroup);
                //return View(userProfiles.ToList());
                section = context.Sections.AsNoTracking().FirstOrDefault(x => x.Name == title);
            }
            SectionDTO sectionDTO = _mapper.Map<SectionDTO>(section);
            return sectionDTO;
        }

        public SectionDTO Get(string Names)
        {
            return _mapper.Map<SectionDTO>(_context.Sections.AsNoTracking().FirstOrDefault(x => x.Name == Names));
        }

        //public IEnumerable<Section> Gets()
        //{
        //    var section = _context.Sections.AsNoTracking().ToList();
        //    var sectionDTO = _mapper.Map<List<SectionDTO>>(section);
        //    return section;
        //}

        public IEnumerable<SectionDTO> Gets()
        {
            return _mapper.Map<List<SectionDTO>>(_context.Sections.AsNoTracking().ToList());
        }
    }
}