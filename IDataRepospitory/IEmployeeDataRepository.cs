using WebApplication1.Models;

namespace WebApplication1.IDataRepospitory
{
    public interface IEmployeeDataRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);        
    }
}
