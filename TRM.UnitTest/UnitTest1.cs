using System;
using TruckRentalManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TRM.UnitTest
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
            TruckPerson tp = new TruckPerson();
            tp.Name = name;
            tp.Address = address;
            tp.Telephone = telephone;

            //Assert
            Assert.IsTrue(actual, "Boolean Test 1 Failed");
        }

    }
}

