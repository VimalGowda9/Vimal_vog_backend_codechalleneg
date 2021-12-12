using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Database.Entities
{
    /// <summary>
    /// Employee Entity Class
    /// </summary>
    public class EmployeeEntity
    {
        /// <summary>
        /// Database Layer Property for Employee Id
        /// </summary>
        [Key]
        public int EmployeeId { get; set; }

        /// <summary>
        /// Database Layer Property for Employee First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Database Layer Property for Employee Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Database Layer Property for Employee Job title
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Database Layer Property for Employee mailing address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Database Layer Property for Employee Department details
        /// </summary>
        public string DepartmentAddress { get; set; }
    }
}
