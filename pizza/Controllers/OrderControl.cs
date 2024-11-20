using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using models;
using models.Interface;
namespace pizza.Controllers;

public class OrderControl : baseControllers
{
    OrderInter _Order;
    public OrderControl(OrderInter Order)
        {
            _Order = Order;
        }

        [Route("[action]/{customerId}/{date}/{idOrder}/")]
   [HttpPost]
   public IActionResult AddOrder(int customerId,DateTime date,int idOrder)
   {
    _Order.AddOrder(customerId,date,idOrder);

    return Ok("new order");
}
}
