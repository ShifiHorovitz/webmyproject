using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using models;
using models.Interface;
namespace pizza.Controllers;


public class PizzaControllers : baseControllers
{

  Ipizza _Pizza;
       public PizzaControllers(Ipizza Pizza)
        {
            _Pizza = Pizza;
        }

[Route("[action]/{id}")]
   [HttpGet]
public IActionResult getById(int id)
    {

      var p1 = _Pizza.getById( id);
            if (p1 != null)
                 return Ok(p1);
       return NotFound("pizza list!!!!");
   
    }


  [Route("[action]/{name}/{isGluten}/{id}/")]
   [HttpPost]
    public IActionResult AddPizza(string name,bool isGluten, int id)
    {
      _Pizza.AddPizza( name, isGluten, id);
      return Ok("newPizzaObject");
      
    }

[Route("[action]/{id}")]
   [HttpGet]
    public IActionResult deletpizza(int id)
    {
      _Pizza.deletpizza(id);
   
       return Ok("the remove sacces");

    }

[Route("[action]/{id}")]
   [HttpPut]
    public IActionResult updateGlutan(bool isGluten, int id)
    {
       var p1 = _Pizza.updateGlutan(isGluten, id);
     
      if(p1!=null)
         return Ok("update the glutan sacces");

      return NotFound("there not findupdate");

        }

}