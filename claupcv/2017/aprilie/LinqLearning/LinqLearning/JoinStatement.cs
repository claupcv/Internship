using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
	public static class JoinStatement
	{
		public static void JoinStatementMethod()
		{
			Console.WriteLine("JoinStatementMethod");

			Department[] departments = Program.CreateMultipleDepartments();
			Employee[] employees = Program.CreateMultipleEmployees();

			var join = from emp in employees
					   join dep in departments
						on emp.DepartmentId equals dep.Id
					   select new
					   {
						   EmployeeName = emp.Name,
						   DepartmentName = dep.Name
					   };

			foreach (var item in join)
			{
				Console.WriteLine($"Employee {item.EmployeeName} works at {item.DepartmentName} department");
			}

		}

		public static void JoinStatementWEithExtensions()
		{
			Console.WriteLine("JoinStatementWEithExtensions");

			Employee[] employees = Program.CreateMultipleEmployees();
			Department[] departments = Program.CreateMultipleDepartments();

			var join = employees.Join(
						departments,
						emp => emp.DepartmentId,
						dep => dep.Id,
						(emp, dep) => new
						{
							EmployeeName = emp.Name,
							DepartmentName = dep.Name
						});

			foreach (var item in join)
			{
				Console.WriteLine($"Employee {item.EmployeeName} works at {item.DepartmentName} department");
			}

		}

		public static void GroupJoinStatementMethod()
		{
			Console.WriteLine("GroupJoinStatementMethod");

			Employee[] employees = Program.CreateMultipleEmployees();
			Department[] departments = Program.CreateMultipleDepartments();
			

			var result = from dep in departments
						 join emp in employees on dep.Id equals emp.DepartmentId into TempEmployees
						 select new
						 {
							 DepartmentName = dep.Name,
							 Employees = TempEmployees
						 };

			foreach (var item in result)
			{
				var employeesCsv = string.Join(", ", item.Employees.Select(emp => $"{emp.Name}"));

				Console.WriteLine($"Department {item.DepartmentName} has the following employees: {employeesCsv}");
			}
		}

		public static void GroupJoinStatementWithExtensions()
		{
			Console.WriteLine("GroupJoinStatementWithExtensions");

			Employee[] employees = Program.CreateMultipleEmployees();
			Department[] departments = Program.CreateMultipleDepartments();

			var results = departments.GroupJoin(
				employees,
				dep => dep.Id,
				emp => emp.DepartmentId,
				(dep, emp) => new
				{
					DepartmentName = dep.Name,
					Employees = emp,
				});

			foreach (var item in results)
			{
				var employeesCsv = string.Join(", ", item.Employees.Select(emp => $"{emp.Name}"));

				Console.WriteLine($"Department {item.DepartmentName} has the following employees: {employeesCsv}");
			}
		}
	}
}
