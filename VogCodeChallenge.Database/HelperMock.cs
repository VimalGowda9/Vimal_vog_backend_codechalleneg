using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database
{
    public static class HelperMock
    {
        #region 'Private Methods for Mocking Data'

        /// <summary>
        /// Method to create mock data for departments
        /// </summary>
        /// <returns>list of department entity</returns>
        public static IList<DepartmentEntity> CreateDepartmentMockData()
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
        public static IList<EmployeeEntity> CreateEmployeeMockData(string departmentAddress)
        {
            List<EmployeeEntity> employee = EmployeeMockData();

            return employee.Where(x => x.DepartmentAddress == departmentAddress).ToList();
        }

        /// <summary>
        /// Method to create mock data for Employee
        /// </summary>
        /// <returns>List of Employees</returns>
        public static List<EmployeeEntity> EmployeeMockData()
        {
            return new List<EmployeeEntity>
            {
                new EmployeeEntity { EmployeeId = 1, FirstName = "Stephen", LastName = "Cornor", JobTitle="Technical Lead", Address="Road Number 1", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 2, FirstName = "Mark", LastName = "Mallabar", JobTitle="Senior Developer", Address="Road Number 2", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 3, FirstName = "Felix", LastName = "Smith", JobTitle="Senior Tester", Address="Road Number 3", DepartmentAddress = "Dep1" },
                new EmployeeEntity { EmployeeId = 4, FirstName = "Emma", LastName = "Miller", JobTitle="Technical Lead", Address="Road Number 4", DepartmentAddress = "Dep2" },
                new EmployeeEntity { EmployeeId = 5, FirstName = "Ava", LastName = "Jones", JobTitle="Senior Developer", Address="Road Number 5", DepartmentAddress = "Dep2" },
                new EmployeeEntity { EmployeeId = 6, FirstName = "Charlotte", LastName = "Anderson", JobTitle="Senior Tester", Address="Road Number 6", DepartmentAddress = "Dep3" },
                new EmployeeEntity { EmployeeId = 6, FirstName = "Andrew", LastName = "Anderson", JobTitle="Junior Tester", Address="Road Number 7", DepartmentAddress = "Dep3" }
            };
        }

        public static DepartmentEntity CreateDepartmentDataForGivenId(string departmentId)
        {
            var department = CreateDepartmentMockData();
            return department.Where(x => x.DepartmentAddress == departmentId).FirstOrDefault();
        }

        #endregion
    }
}
