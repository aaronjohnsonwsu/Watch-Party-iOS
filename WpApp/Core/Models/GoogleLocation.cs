using System;
using System.Collections.Generic;
using System.Text;

namespace WpApp.Core.Models
{
    public class GoogleLocation
    {
        public string PlaceId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string PhoneNumber { get; set; }
    }
}
