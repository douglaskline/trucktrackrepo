using Microsoft.EntityFrameworkCore;

namespace dal
{
   public class truck
   {
      public int Id { get; set; }
      public string truckName { get; set; }
      public string lastName { get; set; }

      public string username { get; set; }
      public string email { get; set; }
   }
}