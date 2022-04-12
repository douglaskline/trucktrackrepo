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
      [DisplayName("State")]
      public string homeState { get; set; }
      [DisplayName("Food Style")]
      public string foodStyle { get; set; }
      [DisplayName("Price Range")]
      public string priceRange { get; set; }
      [DisplayName("Tag Line")]
      public string tagLine { get; set; }
      [DisplayName("URL")]
      public string truckURL { get; set; }
      public byte[] timeStamp {get; set;}
      public List<report> reports {get; set;}
   }
}