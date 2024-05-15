using MyHome.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHome.Factory
{
    public class OrderFactory
    {
        public static Order createOrder(int id, DateTime createdAt, int buyerId, string paymentType, string isCompleted, int projectId, int price)
        {
            Order order = new Order
            {
                Id = id,
                CreatedAt = createdAt,
                BuyerId = buyerId,
                PaymentType = paymentType,
                IsCompleted = isCompleted,
                ProjectId = projectId,
                Price = price
            };
            return order;
        }
    }
}