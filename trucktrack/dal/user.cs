using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace dal
{
   public class user
   {
      public int Id { get; set; }
      public string firstName { get; set; }
      public string lastName { get; set; }

      public string username { get; set; }
      public string email { get; set; }

      public byte[] timeStamp {get; set;}
      public List<report> reports {get; set;}
   }
}