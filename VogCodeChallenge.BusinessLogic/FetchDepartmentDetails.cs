using AutoMapper;
using System.Collections.Generic;
using VogCodeChallenge.BusinessLogic.Models;
using VogCodeChallenge.Database.Repository;

namespace VogCodeChallenge.BusinessLogic
{
    /// <summary>
    /// FetchDepartmentDetails class
    /// </summary>
    public class FetchDepartmentDetails : IFetchDepartmentDetails
    {
        /// <summary>
        /// Private field for department repository
        /// </summary>
        private readonly IDepEmpRepository _departmentRepository;
        
        /// <summary>
        /// Private field for Mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="departmentRepository"></param>
        /// <param name="mapper"></param>
        public FetchDepartmentDetails(IDepEmpRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Method to fetch list of all Departments and its respective employee details
        /// </summary>
        /// <returns>List of Department model</returns>
        public IList<DepartmentModel> GetAllDepartments()
        {
            //Get List of all the Departments
            var department = _departmentRepository.GetAllDepartments();
                                         
            var departmentDetails = _mapper.Map<List<DepartmentModel>>(department);

            //For each Department fetch its Employee details
            foreach (DepartmentModel dep in departmentDetails)
            {
                var employeeDetails = _departmentRepository.GetAllEmployeeDetailsByDepAddress(dep.DepartmentAddress);
                var result = _mapper.Map<List<EmployeeModel>>(employeeDetails);
                dep.Employees = result;
            }

            return departmentDetails;
        }
    }
}