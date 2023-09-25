namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Department { get; set; }
        public int salary { get; set; }

        public Employee(int id, string name, string department, int salary) 
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.salary = salary;   
        }

    }
}
