// using Microsoft.AspNetCore.Mvc;
// using pizza;
using models;
using models.Interface;
namespace ServiceCL;
internal class OrderServ:OrderInter
{
  List <OrderModel> orderList=new List<OrderModel>
    {
        new OrderModel(0547,DateTime.Now,123456),
        new OrderModel(548,DateTime.Now,32872782),
        new OrderModel(854,DateTime.Now,5522852),
        new OrderModel(7522,DateTime.Now,788),
        new OrderModel(7225,DateTime.Now,28727832),
    };

public bool AddOrder(int customerId,DateTime date,int idOrder){
    orderList.Add(new OrderModel(customerId,date,idOrder));
    return true;
}
}