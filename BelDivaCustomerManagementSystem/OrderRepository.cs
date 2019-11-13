using System;
using BelDivaCMS;
using BelDivaCustomerManagementSystem;
using System.Collections.Generic;
using System.Text;

namespace BelDivaCMS.BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId ==10)
            {
                order.orderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order; 
        }

        public bool Save(Order order)
        {
            //saves the passed in customer

            return true;

        }



    }
}
