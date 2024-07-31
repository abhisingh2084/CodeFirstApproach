using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeefirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int Salary { get; set; }
        public string Degignation { get; set; }
    }
}
