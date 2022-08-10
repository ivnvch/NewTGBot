using AutoMapper;
using TGBot.Common.Mapper;
using TGBot.Models;

namespace TGBot.Common
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Section, SectionDTO>().ReverseMap();
            CreateMap<Teacher, TeacherDTO>().ReverseMap();
        }
    }
}
