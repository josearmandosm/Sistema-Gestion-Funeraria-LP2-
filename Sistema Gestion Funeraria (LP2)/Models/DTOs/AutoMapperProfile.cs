using AutoMapper;
using Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Empleados;

namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmpleadoGetDTO, Empleado>().ReverseMap();
            CreateMap<EmpleadoInsertDTO, Empleado>().ReverseMap();
            CreateMap<EmpleadoUpdateDTO, Empleado>().ReverseMap();
        }
    }
}
