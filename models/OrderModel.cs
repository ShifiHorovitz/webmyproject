using models;
namespace models;

public class OrderModel
{

    public int CustomerId { get; set; }
        public DateTime Date { get; set; }
       public int IdOrder { get; set; }
        

   
   public OrderModel(int customerId,DateTime date,int idOrder){
        CustomerId= customerId;
        Date=date;
        IdOrder=idOrder;


   }
}