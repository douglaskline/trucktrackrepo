using Microsoft.EntityFrameworkCore;

namespace dal
{
   public class truck
   {
      public int truckId { get; set; }
      public string truckName { get; set; }
      public string homeCity { get; set; }

      public string homeState { get; set; }
      public string foodStyle { get; set; }
      public string priceRange { get; set; }
      public string tagLine { get; set; }

      public string truckURL { get; set; }

   }
}