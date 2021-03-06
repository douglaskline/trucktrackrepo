using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dal
{
   public class location
   {
      public int locationId { get; set; }
      public string locationName { get; set; }
      public float latitude { get; set; }

      public float longitude { get; set; }
      public string geocode { get; set; }
      public string locationDescription { get; set; }
      public byte[] timeStamp {get; set;}
      public List<report> reports {get; set;}

   }
}