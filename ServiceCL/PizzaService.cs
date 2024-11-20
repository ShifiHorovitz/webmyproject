// using Microsoft.AspNetCore.Mvc;
// using pizza;
using models;
using models.Interface;
namespace ServiceCL;

internal class PizzaSrevice:Ipizza
{
   
    List<PizzaTata> PizzaList = new List<PizzaTata>(){
     new PizzaTata("Abayt",true,6),
     new PizzaTata("mutzarela",false,8),
     new PizzaTata("ziva",true,9),
     new PizzaTata("Etalkit",false,10),
       };

        public PizzaTata  getById(int id)
        {
          foreach (var i in PizzaList)
            if (i.Id == id)
              return i;
         return null;
        }

public Boolean AddPizza(string name,bool isGluten, int id)
    {
       PizzaList.Add(new PizzaTata(name, isGluten, id));
       return true;
    }
 
  public PizzaTata deletpizza(int id)
    {
      foreach(var i in PizzaList){
        if(id==i.Id)
          PizzaList.Remove(i);
          return i;
      }
      return null;
    }

public PizzaTata updateGlutan(bool isGluten, int id)
    {
        foreach(var i in PizzaList)
        {
          if(id==i.Id)
           i.IsGlutan=isGluten;
           return i;
        }
        return null ;
        
        }


   
}