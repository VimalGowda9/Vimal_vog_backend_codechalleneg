using System;
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
            return HelperMock.CreateDepartmentMockData();
        }

        /// <summary>
        /// Method to fetch list of Employee for provided Department
        /// </summary>
        /// <param name="departmentAddress"></param>
        /// <returns>List of Employees</returns>
        public IList<EmployeeEntity> GetAllEmployeeDetails(string departmentAddress)
        {
            return HelperMock.CreateEmployeeMockData(departmentAddress);            
        }
                
        public IEnumerable<EmployeeEntity> GetAll()
        {
            return HelperMock.EmployeeMockData();
        }   

        public DepartmentEntity GetDepartment(string departmentId)
        {
            DepartmentEntity departmentDetail = new DepartmentEntity();

            if(!String.IsNullOrEmpty(departmentId))
            {
                departmentDetail = HelperMock.CreateDepartmentDataForGivenId(departmentId);
            }

            return departmentDetail;
        }
    }
}
