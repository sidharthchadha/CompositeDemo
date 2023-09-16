// File Name: CompanyDetails.cs

using System;

namespace CompositeDemo{
    /// <summary>
    /// Represents a company's details within a company directory structure.
    /// </summary>
    public class CompanyDetails : CompanyDirectory
    {
        private string companyName;
        /// <summary>
        /// Represents a company's details within a company directory structure.
        /// </summary>
        public CompanyDetails(string companyName)
        {
            this.companyName = companyName;
        }

        public void ShowCompanyName()
        {
            Console.WriteLine(companyName);
        }
    }
}
