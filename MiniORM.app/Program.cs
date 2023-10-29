using MiniORM.app.Data.Entities;
using MiniORM.app.Data;
using System.ComponentModel.DataAnnotations;

var connectionString = "Server=DESKTOP-30287UE\\SQLEXPRESS;Database=MiniORM;Integrated Security=True;Encrypt=False";

var context = new SoftUniDbContext(connectionString);

context.Employees.Add(new Employee
{
    FirstName = "Gosho",
    LastName = "Inserted",
    DepartmentId = context.Departments.First().Id,
    IsEmployed = true
});

var employee = context.Employees.Last();
employee.FirstName = "Modified";

    context.SaveChanges();

