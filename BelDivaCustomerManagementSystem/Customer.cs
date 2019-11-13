using System;
using System.Collections.Generic;

namespace BelDivaCustomerManagementSystem
{
    public class Customer
    {

        public Customer()  //default ctor
        {

        }

        public Customer(int customerId) //overloaded constructor 
        {
            CustomerId = customerId; 

        }


       public string FirstName { get; set;  } //no logic is needed
       
        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

       public string FullName  //read only property does not set the property
        {
            get 
            {
                string fullName = FirstName; 
                if(!string.IsNullOrWhiteSpace(LastName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += LastName; 
                }
                return fullName;




            }
        }
        public static int InstanceCount { get; set; }


        private string _lastName;

        public string LastName
        {
            get {
                return _lastName; 
            }
            set { _lastName = value;  }
        }


         //Validates the customer data
         public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid; 
        }
    }
}
