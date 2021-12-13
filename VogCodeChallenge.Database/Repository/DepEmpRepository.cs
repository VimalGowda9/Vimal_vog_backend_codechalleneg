using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database.Repository
{
    /// <summary>
    /// Department Employee Repository class
    /// </summary>
    public class DepEmpRepository : IDepEmpRepository
    {
        /// <summary>
        /// Private field for Vog context
        /// </summary>
        private readonly VogContext _vogContext;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="vogContext"></param>
        public DepEmpRepository(VogContext vogContext)
        {
            _vogContext = vogContext;
        }

        /// <summary>
        /// Method to fetch details of Departments
        /// </summary>
        /// <returns>List of Depatments</returns>
        public IList<DepartmentEntity> GetAllDepartments()
        {            
            return HelperMock.CreateDepartmentMockData();
            //_vogContext.Department.ToList();
        }

        /// <summary>
        /// Method to fetch list of Employee for provided Department
        /// </summary>
        /// <param name="departmentAddress"></param>
        /// <returns>List of Employees</returns>
        public IList<EmployeeEntity> GetAllEmployeeDetailsByDepAddress(string departmentAddress)
        {
            return HelperMock.CreateEmployeeMockData(departmentAddress);
            //_vogContext.Employee.Find(departmentAddress);
        }
          
        /// <summary>
        /// Method to fetch list of all Employee
        /// </summary>
        /// <returns>list of Employee</returns>
        public IEnumerable<EmployeeEntity> GetAllEmployees()
        {
            return HelperMock.EmployeeMockData();
            //_vogContext.Employee.ToList();
        }   

        /// <summary>
        /// Method to fetch Department detail for the provided Department Id/Address
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department details</returns>
        public DepartmentEntity GetDepartmentByDepId(string departmentId)
        {
            return HelperMock.CreateDepartmentDataForGivenId(departmentId);
            //_vogContext.Department.Find(departmentId);
        }
    }
}
