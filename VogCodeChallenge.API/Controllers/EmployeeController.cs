using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.BusinessLogic;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        /// <summary>
        /// Private field for FetchEmployeeDetails class
        /// </summary>
        private readonly IFetchEmployeeDetails _employeeDetails;

        /// <summary>
        /// Private field for Mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="fetchEmployeeDetails"></param>
        /// <param name="mapper"></param>
        public EmployeeController(IFetchEmployeeDetails fetchEmployeeDetails, IMapper mapper)
        {
            _employeeDetails = fetchEmployeeDetails;
            _mapper = mapper;
        }

        /// <summary>
        /// Method to fetch list of all Employee details
        /// </summary>
        /// <returns>list of Employee</returns>
        [HttpGet("")]
        public IActionResult GetAll()
        {
            var employeeDetails = _employeeDetails.GetAll();

            if(employeeDetails != null && employeeDetails.Count() > 0)
            {
                var result = _mapper.Map<List<Employee>>(employeeDetails);
                return Ok(result);
            }
            else
            {
                return NotFound();
            }            
        }

        /// <summary>
        /// Method to fetch department detail for the provided department Id/Address
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns>Department Detail</returns>
        [HttpGet("department/{departmentId}")]
        public IActionResult GetDepartmentById([FromRoute]string departmentId)
        {
            if (String.IsNullOrEmpty(departmentId))
            {
                return NoContent();
            }
            else
            {
                var department = _employeeDetails.GetDepartmentByDepId(departmentId);
                var result = department != null ? _mapper.Map<Department>(department) : null;
                if(result == null || String.IsNullOrEmpty(result.DepartmentAddress))
                {
                    return NotFound();
                }
                
                return Ok(result);
            }                
        }
    }
}
