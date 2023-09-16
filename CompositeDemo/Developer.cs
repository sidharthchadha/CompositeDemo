// File Name: Developer.cs

using System;

namespace CompositeDemo
{
    // Developer class inherits from Employee
    public class Developer : Employee
    {
        protected string name;
        protected long empID;
        /// <summary>
        /// Initializes a new instance of the Developer class.
        /// </summary>
        /// <param name="name">The name of the developer.</param>
        /// <param name="empID">The employee ID of the developer.</param>
        public Developer(string name, long empID)
        {
            this.name = name;
            this.empID = empID;
        }
        /// <summary>
        /// Prints the details of the Developer employee.
        /// </summary>
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine($"Name: {name} empID: {empID} Designation: Developer");
        }

    }
}
