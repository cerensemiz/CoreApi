using AutoMapper;
using EntityLayer.Models;
using EntityLayer.ViewModels;

namespace EntityLayer.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
           CreateMap<Student,StudentVM>().ReverseMap(); 
        } 
    }
}
