using System;
using System.Collections.Generic;
namespace CompositeDemo
{
    public class CompanyDirectory : Employee
    {
        /// <summary>
        /// Represents a company directory that can contain a list of employees.
        /// </summary>
        private List<Employee> employeeList;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyDirectory"/> class.
        /// </summary>
        public CompanyDirectory()
        {
            employeeList = new List<Employee>();
        }
        /// <summary>
        /// Prints the details of all employees in the company directory.
        /// </summary>
        public override void PrintEmployeeDetails()
        {
            foreach (var employee in employeeList)
            {
                employee.PrintEmployeeDetails();
            }
        }
        /// <summary>
        /// Adds an employee to the company directory.
        /// </summary>
        /// <param name="employee">The employee to add.</param>
        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
        /// <summary>
        /// Gets the list of employees in the company directory.
        /// </summary>
        /// <returns>The list of employees.</returns>
        public List<Employee> GetEmployees()
        {
            return employeeList;
        }
        /// <summary>
        /// Gets the size of the company (number of employees in the directory).
        /// </summary>
        /// <returns>The size of the company.</returns>
        public int GetCompanySize()
        {
            return employeeList.Count;
        }
    }

}
