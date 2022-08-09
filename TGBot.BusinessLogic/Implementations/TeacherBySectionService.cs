using Microsoft.EntityFrameworkCore;
using TGBot.BusinessLogic.Interfaces;
using TGBot.Models;

namespace TGBot.BusinessLogic.Implementations
{
    public class TeacherBySectionService : ITeacherBySectionService
    {
        DataContext _context;
        public TeacherBySectionService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<TeacherBySection> Gets()
        {
            _context.Database.ExecuteSqlRaw(@"CREATE VIEW View_TeacherBySection AS
                SELECT s.Name AS SectionName, s.Location AS SectionLocation, s.RunningTime AS SectionRunningTime,
                t.FullName AS TeacherFullName, t.MobilePhone AS TeacherMobilePhone 
                FROM Sections s
                JOIN Teachers t ON s.Id = t.SectionId");
            _context.SaveChanges();

            return _context._TeacherBySections.AsNoTracking().ToList();
            
        }
    }
}
