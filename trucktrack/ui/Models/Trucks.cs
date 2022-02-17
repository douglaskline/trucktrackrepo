using System;
using System.ComponentModel.DataAnnotations;

namespace ui.Models
{
    public class Truck
    {
        public int truckID { get; set; }
        public string truckName { get; set; }
        public string homeCity { get; set; }
        public string homeState { get; set; }
        public string foodStyle { get; set; }
        //public string priceRange { get; set; }
        public string Tagline { get; set; }
        public string url { get; set; }
    }
}