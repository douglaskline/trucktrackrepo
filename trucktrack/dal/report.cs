using Microsoft.EntityFrameworkCore;
using System;

namespace dal
{
   public class report
   {
      public int Id { get; set; }

      public DateTime reportTime {get;set;}

      public int truckId {get; set;}
      public int locationId {get; set;}

      public DateTime startTime {get;set;}
      public DateTime endTime {get;set;}
      
      public int userId {get; set;}
      public dal.user user {get; set;}
      public dal.location location {get; set;}
      public dal.truck truck {get; set;}
      public byte[] timeStamp {get; set;}

   }
}