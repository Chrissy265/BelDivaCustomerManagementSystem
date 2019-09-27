using System;
using BelDivaCustomerManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BelDivaCMS.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Mary";
            customer.LastName = "Smith";

            string expected = "Mary, Smith";
            //--Act
            string actual = customer.FullName;

            //--Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void EmptyFN()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Smith"
            };
            string expected = "Smith";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyLN()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Mary"
            };
            string expected = "Mary";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
        
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Mary";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //--Act 

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);   
        }


        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange 
            var customer = new Customer
            {
                LastName = "Hobbit",
                EmailAddress = "KrisHobbit77@gmail.com"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert 
            Assert.AreEqual(expected, actual); 
        }


        [TestMethod]
       
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
                EmailAddress = "KrisHobbit77@gmail.com"
            };

            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual); 
        }
    }
}


