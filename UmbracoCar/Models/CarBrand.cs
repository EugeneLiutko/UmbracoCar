using System;

namespace UmbracoCar.Models
{
    public class CarBrand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public DateTime FoundationDate { get; set; }
        public string OriginCountry { get; set; }
        public string Description { get; set; }
    }
}