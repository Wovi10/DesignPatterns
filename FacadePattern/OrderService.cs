﻿namespace FacadePattern;

public class OrderService
{
    public bool HasEnoughOrders(int customerId)
    {
        return customerId > 5;
    }
}