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
      public List<SelectListItem> durations {get; set;}

      public int truckId {get; set;}
      public int locationId {get; set;}
      public int minutesLonger {get; set;}
      public reportViewModel(){
         locations = new List<SelectListItem>();
         trucks = new List<SelectListItem>();
         durations = new List<SelectListItem>();
         durations.Add(new SelectListItem("5 minutes", "5"));
         durations.Add(new SelectListItem("15 minutes", "15"));
         durations.Add(new SelectListItem("30 minutes", "30"));
         durations.Add(new SelectListItem("45 minutes", "45"));
         durations.Add(new SelectListItem("60 minutes", "60"));
         durations.Add(new SelectListItem("90 minutes", "90"));
         durations.Add(new SelectListItem("2 hours", "120"));
         durations.Add(new SelectListItem("3 hours", "180"));
      }

   }
}