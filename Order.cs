using System;

public class Order
{
	public Order()
	{
	}

    public string orderDate { get; set; }
    public int orderId { get; set; }







    public List<Order> Retrieve()
    {
        //Retrieves all of the customers

        return new List<Order>();
    }
    //Retrieve one customer

    public Order Retrieve(int orderId) //method signature does not return type
    {
        //Code that retrieves the defined customer

        return new Order();
    }


    //Save the current customer

    public bool Save()
    {
        //Code that saves the defined customer

        return true;
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
