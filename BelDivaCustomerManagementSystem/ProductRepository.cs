using System;
using BelDivaCustomerManagementSystem;
using BelDivaCMS; 
using System.Collections.Generic;
using System.Text;

namespace BelDivaCMS.BL
{
    class ProductRepository
    {

        public Product Retrieve(int productId)
        {

            Product product = new Product(productId);

            if(productId ==2)
            {
                product.productName = "Cookie Monster";
                product.descripton = "Cookie Monster jar";
                product.currentPrice = 10.25M; 
            }

            return product; 
        }

        //public List<Product> Retrieve(int productId)
        //{
        //    return new List <Product>(); 

        //}


        public bool Save(Product product)
        {
            //saves the passed in customer

            return true;

        }
    }

    
    }

