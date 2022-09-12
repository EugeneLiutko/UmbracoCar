using System;

namespace UmbracoCar.Models
{
    public class CarModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime LaunchDate { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}