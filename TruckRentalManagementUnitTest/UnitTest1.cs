using System;
using TruckRentalManagementUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TruckRentalManagementUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ID_1_TestLoginVerificationTrue()
        {
            // This test case checks if the minimum account number is accepted
            // Arrange
            string username = "Yvan";
            string password = "123";

            // Act
            DataAccessLayer.DB.TruckPerson tp = new DataAccessLayer.DBTruckPerson();
            tp.Name = name;
            tp.Address = address;
            tp.Telephone = telephone;
            bool actual = bankAccount.isAccountNumberVerified(actualAccountNumber);

            //Assert
            Assert.IsTrue(actual, "Boolean Test 1 Failed");
        }

    }
}
