using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.BusinessLogic.Models;
using VogCodeChallenge.Database.Entities;
using VogCodeChallenge.Database.Repository;

namespace VogCodeChallenge.BusinessLogic
{
    public class FetchEmployeeDetails : IFetchEmployeeDetails
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public FetchEmployeeDetails(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            return GetEmployeeDetails();
        }

        public IList<EmployeeModel> ListAll()
        {
            return GetEmployeeDetails().ToList();
        }

        public DepartmentModel GetDepartment(string departmentId)
        {
            DepartmentModel departmentDetail = new DepartmentModel();

            if (!String.IsNullOrEmpty(departmentId))
            {
                var department = _departmentRepository.GetDepartment(departmentId);
                departmentDetail = _mapper.Map<DepartmentModel>(department);
            }
                
            return departmentDetail;
        }

        private IEnumerable<EmployeeModel> GetEmployeeDetails()
        {
            var employee = _departmentRepository.GetAll();
            var mapping = _mapper.Map<IEnumerable<EmployeeModel>>(employee);
            return mapping;
        }

        
    }
}
