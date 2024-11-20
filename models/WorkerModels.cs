using models;
namespace models;

public class WorkerModels
{

    public string? Name { get; set; }  
    public string? LastName { get; set; }
    public int Id { get; set; }
   public int SumHours { get; set; }
   
   public WorkerModels(string name,string lastName,int id,int sumHours){
         string Name= name; 
         string LastName= lastName;
         int Id=id; 
         int SumHours=sumHours;


   }
}