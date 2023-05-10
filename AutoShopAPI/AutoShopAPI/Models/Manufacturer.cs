﻿namespace AutoShopAPI.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Car> Cars { get; set; }
    }
}
