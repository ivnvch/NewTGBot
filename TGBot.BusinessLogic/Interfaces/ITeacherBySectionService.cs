using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGBot.Common.Mapper;
using TGBot.Models;

namespace TGBot.BusinessLogic.Interfaces
{
    public interface ITeacherBySectionService
    {
        IEnumerable<TeacherBySection> Gets();
    }
}
