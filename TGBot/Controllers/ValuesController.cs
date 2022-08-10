using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TGBot.BusinessLogic.Interfaces;
using TGBot.Common.Mapper;

namespace TGBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        private readonly ITeacherService _teacherService;
        //private List<SectionDTO> SectionDTOs { get; set; }

        public ValuesController(ISectionService sectionService, ITeacherService teacherService)
        {
            _sectionService = sectionService;
            _teacherService = teacherService;
            //SectionDTOs = new List<SectionDTO>();
        }
    }
}