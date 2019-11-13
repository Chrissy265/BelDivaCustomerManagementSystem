using System;
using System.Collections.Generic;
using System.Text;
using BelDivaCustomerManagementSystem;
namespace BelDivaCMS.BL
{
   public class CustomerRepository
    {

        public Customer Retrieve(int customerId)
        {
            //Create instance of the customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId); 

            //code retrieves the defined customer 


            //hardcoded values to return a populated customer

            if(customerId ==1)
            {
                customer.EmailAddress = "cbarkley@gmail.com";
                customer.FirstName = "Charles";
                customer.LastName = "Barkley";
                  
            }

            return customer; 
        }

        public bool Save(Customer customer)
        {
            //saves the passed in customer

            return true; 

        }

    }
}
