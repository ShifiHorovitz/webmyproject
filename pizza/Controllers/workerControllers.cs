using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using models;
using models.Interface;
namespace pizza.Controllers;

public class workerControllers: baseControllers
{
    Iworker _Worker;
    public workerControllers(Iworker Worker)
        {
            _Worker = Worker;
        }

    [Route("[action]/{id}/{sumHours}/")]
   [HttpPost]
   public IActionResult SumId(int id,int sumHours){
             
    var p1 =_Worker.SumId(id, sumHours);
     
      if(p1!=null)
         return Ok("update the glutan sacces");

      return NotFound("there not findupdate");

             

            
       }



//    public IActionResult AddOrder(int customerId,DateTime date,int idOrder)
//    {
//     _Worker.AddOrder(customerId,date,idOrder);

//     return Ok("new order");
// }
}
