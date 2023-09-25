using WebApplication1.IDataRepospitory;
using WebApplication1.Models;

namespace WebApplication1.DataRepository
{
    public class EmployeeDataRepository : IEmployeeDataRepository
    {
        public EmployeeDataRepository() { }
        public IEnumerable<Employee> GetAllEmployeeFromDb() 
        {
            Employee employee = new Employee(1,"Sanjay", "IT", 10000);
            Employee employee1 = new Employee(2,"Saurabh", "HR", 20000);
            Employee employee2 = new Employee(3, "Sonam", "Exec", 30000);
            List<Employee> emplist = new List<Employee>();
            emplist.Add(employee);
            emplist.Add(employee1);
            emplist.Add(employee2);
            return emplist;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {   
            return GetAllEmployeeFromDb();
        }

        public Employee GetEmployeeById(int id)
        {
            return GetAllEmployeeFromDb().ToList().Where(a => a.Id == id).First();
        }
    }
}
