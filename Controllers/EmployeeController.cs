using Microsoft.AspNetCore.Mvc;
using WebApplication1.IDataRepospitory;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeDataRepository _employeeDataRepository;
        public EmployeeController(IEmployeeDataRepository employeeDataRepository) 
        {
            _employeeDataRepository = employeeDataRepository;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeDataRepository.GetAllEmployees();
        }
        [Route("{id}")]
        public Employee GetEmployeeById(int id) 
        {
            return _employeeDataRepository.GetEmployeeById(id);
        }
    }
}
