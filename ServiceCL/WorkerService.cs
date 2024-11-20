// using Microsoft.AspNetCore.Mvc;
// using pizza;
using models;
using models.Interface;
namespace ServiceCL;
internal class WorkerService:Iworker
{
   List<WorkerModels> WorkerList = new List<WorkerModels>(){
    
     new WorkerModels("shifi","horovitz",328128269,20),
     
       };

       public int SumId(int id,int sumHours){
             foreach (var i in WorkerList)
            if (i.Id == id)
              return i.SumHours;

            return -1;
       }
       
}