using AutoMapper;
using BlackCoderLeaveManagementApp.Data;
using BlackCoderLeaveManagementApp.Models;

namespace BlackCoderLeaveManagementApp.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Syntax: CreateMap<Source_Type, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}








