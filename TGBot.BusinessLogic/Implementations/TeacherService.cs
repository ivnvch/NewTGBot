using AutoMapper;
using TGBot.BusinessLogic.Interfaces;
using TGBot.Common.Mapper;
using Microsoft.EntityFrameworkCore;
using TGBot.Models;

namespace TGBot.BusinessLogic.Implementations
{
    public class TeacherService:ITeacherService
    {
        public IMapper Mapper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IMapper _mapper;
        DataContext _context;

        public TeacherService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public TeacherDTO Get(int id)
        {
            return _mapper.Map<TeacherDTO>(_context.Sections.AsNoTracking().FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<TeacherDTO> Gets()
        {
            return _mapper.Map<List<TeacherDTO>>(_context.Sections.AsNoTracking().ToList());
        }

        //public SectionDTO DTO(string title)
        //{
        //    Section section = new Section();
        //    using (DataContext context = new DataContext())
        //    {
        //        //var userProfiles = _db.UserProfiles.Include(c => c.UserGroup);
        //        //return View(userProfiles.ToList());
        //        section = context.Sections.AsNoTracking().FirstOrDefault(x => x.Name == title);
        //    }
        //    SectionDTO sectionDTO = _mapper.Map<SectionDTO>(section);
        //    return sectionDTO;
        //}

        public TeacherDTO TeacherDTO()
        {
            Teacher teacher = new Teacher();
            using (DataContext context = new DataContext())
            {
                teacher = context.Teachers.Include(t => t.SectionId).SingleOrDefault();
            }

            TeacherDTO teach = _mapper.Map < TeacherDTO>(teacher);

            return teach;
        }
    }
}
