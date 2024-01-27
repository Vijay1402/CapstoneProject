using BlogLib;
using System.Collections.Generic;
using System.Web.Http;

namespace BlogAPI
{
    [RoutePrefix("api/employees")]
    public class EmpInfoController : ApiController
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult SaveEmployee(EmpInfo employee)
        {
            _employeeRepository.SaveEmployee(employee);
            return Ok();
        }

        [HttpGet]
        [Route("{email}")]
        public IHttpActionResult ValidateEmployeeLogin(string email, int passCode)
        {
            var isValid = _employeeRepository.ValidateEmployeeLogin(email, passCode);
            return Ok(isValid);
        }
    }
}