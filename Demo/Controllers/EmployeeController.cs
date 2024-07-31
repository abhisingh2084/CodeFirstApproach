using Demo.Interfaces;
using Demo.Models;
using Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService employeeService;
        public EmployeeController(IEmployeeService service)
        {
            employeeService = service;
        }

        /// <summary>
        /// get all employess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmployeeList")]
        public IActionResult GetEmployeeList()
        {
            try
            {
                var employees = employeeService.GetEmployeeList();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        /// <summary>
        /// get employee by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEmployeeByID")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                var employee = employeeService.GetEmployeeDetailById(id);
                return Ok();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// save employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("EditEmployee")]
        public IActionResult SaveEmployees(Employees employeeModel)
        {
            try
            {
                var model = employeeService.SaveEmployee(employeeModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// save employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployees(int id)
        {
            try
            {
                var model = employeeService.DeleteEmployee(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


    }
}
