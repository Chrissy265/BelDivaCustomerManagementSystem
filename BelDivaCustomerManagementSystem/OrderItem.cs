﻿using System;
using System.Collections.Generic;
using System.Text;
using BelDivaCustomerManagementSystem; 

namespace BelDivaCMS.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;

        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        
        public int Quantity { get; set; }

        public decimal? purchasePrice { get; set; }




    


        public OrderItem Retrieve(int orderItemId)
        {

            return new OrderItem();
        }




        public bool Save()
        {


            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <=0) isValid = false;

            if (ProductId <= 0) isValid = false;

            if (purchasePrice <= 0) isValid = false;



            return isValid;
        }
    }


}

