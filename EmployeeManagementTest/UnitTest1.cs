using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement;

namespace EmployeeManagementTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Salary sal = new Salary();

            SalaryUpdateModel updateModel = new SalaryUpdateModel();
            {
                Salary = 1;
                Month = "Jan";
                EmployeeSalary = 20000;
                EmployeeId = 1;
            };
            //Act
            int EmpSalary = sal.UpdateEmployeeSalary(updateModel);

            //Assert
            Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);
        }
    }
}