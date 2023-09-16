// File Name: Manager.cs

using System;

namespace CompositeDemo
{
    /// <summary>
    /// Represents a Manager employee with a name and employee ID.
    /// </summary>
    public class Manager : Employee
    {
        protected string name;
        protected long empID;
        /// <summary>
        /// Initializes a new instance of the Manager class with the specified name and employee ID.
        /// </summary>
        /// <param name="name">The name of the manager.</param>
        /// <param name="empID">The employee ID of the manager.</param>
        public Manager(string name, long empID)
        {
            this.name = name;
            this.empID = empID;
        }
        /// <summary>
        /// Overrides the base class method to print employee details, including name, employee ID, and designation.
        /// </summary>

        public override void PrintEmployeeDetails()
        {
            Console.WriteLine($"Name: {name} empID: {empID} Designation: Manager");
        }
    }

}