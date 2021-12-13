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
    /// <summary>
    /// FetchEmployeeDetails Class
    /// </summary>
    public class FetchEmployeeDetails : IFetchEmployeeDetails
    {
        /// <summary>
        /// Private field for Repository
        /// </summary>
        private readonly IDepEmpRepository _depEmpRepository;

        /// <summary>
        /// Private field for Mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="departmentRepository"></param>
        /// <param name="mapper"></param>
        public FetchEmployeeDetails(IDepEmpRepository departmentRepository, IMapper mapper)
        {
            _depEmpRepository = departmentRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Method to fetch all Employee Details
        /// </summary>
        /// <returns>Employee details</returns>
        public IEnumerable<EmployeeModel> GetAll()
        {
            return GetEmployeeDetails();
        }

        /// <summary>
        /// Method to Fetch list of all Employee details
        /// </summary>
        /// <returns>List of Employee details</returns>
        public IList<EmployeeModel> ListAll()
        {
            return GetEmployeeDetails().ToList();
        }

        /// <summary>
        /// Method to get Department details for the supplied Department Is/Address
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        public DepartmentModel GetDepartmentByDepId(string departmentId)
        {
            //Get the Department detail
            var department = _depEmpRepository.GetDepartmentByDepId(departmentId);
            var depMapping = new DepartmentModel();

            if (department != null)
            {
                //Get Employee detail for the relevant department
                var employeeDetails = _depEmpRepository.GetAllEmployeeDetailsByDepAddress(department.DepartmentAddress);
                var empMapping = employeeDetails != null ? _mapper.Map<List<EmployeeModel>>(employeeDetails) : null;

                depMapping = _mapper.Map<DepartmentModel>(department);
                depMapping.Employees = empMapping;
            }
            
            return depMapping;                        
        }

        /// <summary>
        /// Private method to get list of all Employee details from Database.
        /// </summary>
        /// <returns>list of Employee details</returns>
        private IEnumerable<EmployeeModel> GetEmployeeDetails()
        {
            var employee = _depEmpRepository.GetAllEmployees();
            var empMapping = employee != null ? _mapper.Map<IEnumerable<EmployeeModel>>(employee) : null;
            return empMapping;
        }
        
    }
}
