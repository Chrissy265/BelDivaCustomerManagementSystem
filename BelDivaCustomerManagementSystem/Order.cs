using System;
using System.Collections.Generic;
using BelDivaCustomerManagementSystem;

public class Order
{
    public Order()
    {
    }

    public Order(int orderId)
    {
        OrderId = orderId; 
    }

    public DateTimeOffset? orderDate { get; set; }  //date can be set in different timezones
    public int orderId { get; set; }







    public List<Order> Retrieve()
    {
        

        return new List<Order>();
    }
    

    public Order Retrieve(int orderId) 
    {
       

        return new Order();
    }


 

    public bool Save()
    {
        

        return true;
    }
   
    public bool Validate()
    {
        var isValid = true;

        if (orderDate == null) isValid = false; 

        return isValid;
    }
}

