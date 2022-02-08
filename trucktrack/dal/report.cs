using Microsoft.EntityFrameworkCore;

namespace dal
{
   public class report
   {
      public int Id { get; set; }

      public DateTime reportTime {get;set;}

      public int userId {get; set;}
      public int truckId {get; set;}
      public int locationId {get; set;}

      public DateTime startTime {get;set;}
      public DateTime endTime {get;set;}
   }
}