using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database.Repository
{
    /// <summary>
    /// Department Repository class
    /// </summary>
    public class DepartmentRepository : IDepartmentRepository
    {
        /// <summary>
        /// Private field for Vog context
        /// </summary>
        private readonly VogContext _vogContext;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="vogContext"></param>
        public DepartmentRepository(VogContext vogContext)
        {
            _vogContext = vogContext;
        }

        /// <summary>
        /// Method to fetch details of Departments
        /// </summary>
        /// <returns>List of Depatments</returns>
        public IList<DepartmentEntity> GetAllDepartments()
        {
            return CreateDepartmentMockData();
        }

        /// <summary>
        /// Method to fetch list of Employee for provided Department
        /// </summary>
        /// <param name="departmentAddress"></param>
        /// <returns>List of Employees</returns>
        public IList<EmployeeEntity> GetAllEmployeeDetails(string departmentAddress)
        {
            return CreateEmployeeMockData(departmentAddress);            
        }

        /// <summary>
        /// Method to create mock data for departments
        /// </summary>
        /// <returns>list of department entity</returns>
        private IList<DepartmentEntity> CreateDepartmentMockData()
        {
            var department = new List<DepartmentEntity>
            {
                new DepartmentEntity { DepartmentAddress = "Dep1", DepartmentName = "Agriculture"},
                new DepartmentEntity { DepartmentAddress = "Dep2", DepartmentName = "Mortgage"},
                new DepartmentEntity { DepartmentAddress = "Dep3", DepartmentName = "Sales"}
            };

            return department;
        }

        /// <summary>
        /// Method to create mock data for employees
        /// </summary>
        /// <returns>list of employee entity</returns>
        private IList<EmployeeEntity> CreateEmployeeMockData(string departmentAddress)
        {
            var employee = new List<EmployeeEntity>
            {
                new EmployeeEntity { EmployeeId = 1, FirstName = "Stephen", LastName = "Cornor", JobTitle="Technical Lead", Address="Road Number 1", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 2, FirstName = "Mark", LastName = "Mallabar", JobTitle="Senior Developer", Address="Road Number 2", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 3, FirstName = "Felix", LastName = "Smith", JobTitle="Senior Tester", Address="Road Number 3", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 4, FirstName = "Emma", LastName = "Miller", JobTitle="Technical Lead", Address="Road Number 4", DepartmentAddress = "Dep2" },
                new EmployeeEntity { EmployeeId = 5, FirstName = "Ava", LastName = "Jones", JobTitle="Senior Developer", Address="Road Number 5", DepartmentAddress = "Dep2" },
                new EmployeeEntity { EmployeeId = 6, FirstName = "Charlotte", LastName = "Anderson", JobTitle="Senior Tester", Address="Road Number 6", DepartmentAddress = "Dep3" },
                new EmployeeEntity { EmployeeId = 6, FirstName = "Andrew", LastName = "Anderson", JobTitle="Junior Tester", Address="Road Number 7", DepartmentAddress = "Dep3" }
            };

            return employee.Where(x => x.DepartmentAddress == departmentAddress).ToList();
        }
    }
}
