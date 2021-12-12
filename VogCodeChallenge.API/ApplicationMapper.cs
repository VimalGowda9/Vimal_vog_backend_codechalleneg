using AutoMapper;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.BusinessLogic.Models;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.API
{
    /// <summary>
    /// Automapper Class
    /// </summary>
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DepartmentModel, Department>();
            CreateMap<EmployeeModel, Employee>();
            CreateMap<DepartmentEntity, DepartmentModel>();
            CreateMap<EmployeeEntity, EmployeeModel>();
        }
    }
}