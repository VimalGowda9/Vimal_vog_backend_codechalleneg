using System.Collections.Generic;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database.Repository
{
    /// <summary>
    /// Department Repository Interface
    /// </summary>
    public interface IDepartmentRepository
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
        IList<EmployeeEntity> GetAllEmployeeDetails(string departmentAddress);

        IEnumerable<EmployeeEntity> GetAll();

        DepartmentEntity GetDepartment(string departmentId);

    }
}