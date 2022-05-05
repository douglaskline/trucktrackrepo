using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace dal
{
   public class reportViewModel
   {
      public List<SelectListItem> locations {get; set;}
      public List<SelectListItem> trucks {get; set;}

      public int truckId {get; set;}
      public int locationId {get; set;}
      public reportViewModel(){
         locations = new List<SelectListItem>();
         trucks = new List<SelectListItem>();
      }

   }
}