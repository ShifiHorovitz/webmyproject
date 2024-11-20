using models;
namespace models;

public class PizzaTata
{

    public string? Name { get; set; }  
    public bool IsGlutan { get; set; }
    public int Id { get; set; }
   
   public PizzaTata(string name,bool isGlutan,int id){
         string Name= name; 
         bool IsGlutan=isGlutan ; 
         int Id=id; 
   


   }
}