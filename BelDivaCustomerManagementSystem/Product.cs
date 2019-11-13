using System;
using System.Collections.Generic;
using System.Text;
using BelDivaCustomerManagementSystem; 

namespace BelDivaCMS.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public string productName { get; set; }
        public string descripton  { get; set; }
        public decimal? currentPrice { get; set; }  
        public int ProductId { get; private set; }



        
        
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            if (currentPrice == null) isValid = false; 

            return isValid;
        }
    }

}

