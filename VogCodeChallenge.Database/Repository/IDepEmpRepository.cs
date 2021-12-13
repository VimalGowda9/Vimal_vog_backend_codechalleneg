using System.Collections.Generic;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database.Repository
{
    /// <summary>
    /// Department Employee Repository Interface
    /// </summary>
    public interface IDepEmpRepository
    {
        /// <summary>
        /// Method to fetch details of Departments
        /// </summary>
        /// <returns>List of Depatments</returns>
        IList<DepartmentEntity> GetAllDepartments();

        /// <summary>
        /// Method to fetch list of Employee for provided Department
        /// </summary>
        /// <param name="departmentAddress"></param>
        /// <returns>List of Employees</returns>
        IList<EmployeeEntity> GetAllEmployeeDetailsByDepAddress(string departmentAddress);

        /// <summary>
        /// Method to fetch details of all Employees
        /// </summary>
        /// <returns>List of Employees</returns>
        IEnumerable<EmployeeEntity> GetAllEmployees();

        /// <summary>
        /// Method to fetch Department detail by Id
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Details</returns>
        DepartmentEntity GetDepartmentByDepId(string departmentId);

    }
}