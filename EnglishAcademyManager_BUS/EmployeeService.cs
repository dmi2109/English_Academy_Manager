using EnglishAcademyManager_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManager_BUS
{
    public class EmployeeService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();
        public List<Employee> GetAll()
        {
            return context.Employee.ToList();
        }

        public string AddEmployee(Employee employee)
        {
            try
            {
                if (context.Employee.Any(s => s.employee_id == employee.employee_id))
                {
                    return "Mã nhân viên đã tồn tại.";
                }

                //employee.Status = true;
                context.Employee.Add(employee);
                context.SaveChanges();
                return "Thêm nhân viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi thêm nhân viên: {ex.Message}";
            }
        }
        public Employee GetEmployeeById(string Employee_id)
        {
            return context.Employee.FirstOrDefault(s => s.employee_id == Employee_id);
        }
        public string UpdateEmployee(Employee employee)
        {
            try
            {
                var existingEmployee = context.Employee.FirstOrDefault(s => s.employee_id == employee.employee_id);
                if (existingEmployee == null)
                {
                    return "Nhân viên không tồn tại.";
                }

                existingEmployee.last_name = employee.last_name;
                existingEmployee.first_name = employee.first_name;
                existingEmployee.phone = employee.phone;
                existingEmployee.email = employee.email;

                context.SaveChanges();
                return "Cập nhật thông tin sinh viên thành công!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi cập nhật sinh viên: {ex.Message}";
            }
        }
        public string DeleteEmployee(string employeeId)
        {
            try
            {
                var existingEmployee = context.Employee.FirstOrDefault(s => s.employee_id == employeeId);
                if (existingEmployee == null)
                {
                    return "Sinh viên không tồn tại.";
                }
                //existingEmployee.Status = false;
                context.SaveChanges();
                return "Đã đánh dấu nhân viên là đã xóa!";
            }
            catch (Exception ex)
            {
                return $"Lỗi khi xóa sinh viên: {ex.Message}";
            }
        }

    }
}

