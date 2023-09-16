using CompositeDemo;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // Test method to check the Composite Pattern in CompanyDetails
        [TestMethod]
        public void TestCompositePattern()
        {
            // Creating developer and manager objects
            Employee d1 = new Developer("sid", 10);
            Employee d2 = new Developer("Boa", 11);
            Employee d3 = new Developer("Robin", 12);
            Employee m1 = new Manager("Nami", 1);

            CompanyDetails companyDetails = new CompanyDetails("One Piece");
            companyDetails.AddEmployee(m1);
            companyDetails.AddEmployee(d1);
            companyDetails.AddEmployee(d2);
            companyDetails.AddEmployee(d3);

            // Asserting that the company has 4 employees
            Assert.AreEqual(4, companyDetails.GetCompanySize());
        }
    }
}