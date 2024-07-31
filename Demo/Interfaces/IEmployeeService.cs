using Demo.Models;
using Demo.ViewModels;

namespace Demo.Interfaces
{
    public interface IEmployeeService
    {
        List<Employees> GetEmployeeList();
        Employees GetEmployeeDetailById(int empId);
        ResponseModel SaveEmployee(Employees employee);
        ResponseModel DeleteEmployee(int empId);
    }
}
