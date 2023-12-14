using EmployeeCrudBlazor.Context;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EmployeeCrudBlazor.Data
{
	public class EmployeeService
	{
		private readonly ApplicationDBContext _applicationDBContext;	
		public EmployeeService(ApplicationDBContext applicationDBContext) 
		{
			_applicationDBContext = applicationDBContext;
		}

		// Get all emloyee list
		public async Task<List<Employee>> GetAllEmployees()
		{
			return await _applicationDBContext.Employees.ToListAsync();
		}

		//Add Employee
		public async Task<bool> AddNewEmployee(Employee employee)
		{
			await _applicationDBContext.Employees.AddAsync(employee);
			await _applicationDBContext.SaveChangesAsync();
			return true;
		}

		//Get Employee record by Id
		public async Task<Employee> GetEmployeeByid(int id)
		{
			Employee employee = await _applicationDBContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(id));
			return employee;
		}

		//Update Employee data
		public async Task<bool> UpdateEmployeeDetails(Employee employee)
		{
			_applicationDBContext.Employees.Update(employee);
			await _applicationDBContext.SaveChangesAsync();
			return true;
		}


		//Delete Employee
		public async Task<bool> DeleteEmployee(Employee employee)
		{
			_applicationDBContext.Employees.Remove(employee);
			await _applicationDBContext.SaveChangesAsync();
			return true;
		}
	}
}
