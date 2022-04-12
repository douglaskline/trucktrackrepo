using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;


namespace dal
{
   public class truck
   {
 
      public int truckId { get; set; }

      [DisplayName("Truck Name")]
      public string truckName { get; set; }
      [DisplayName("City")]
      public string homeCity { get; set; }
      public string homeState { get; set; }
      public string foodStyle { get; set; }
      public string priceRange { get; set; }
      public string tagLine { get; set; }
      public string truckURL { get; set; }
      public byte[] timeStamp {get; set;}
      public List<report> reports {get; set;}
   }
}