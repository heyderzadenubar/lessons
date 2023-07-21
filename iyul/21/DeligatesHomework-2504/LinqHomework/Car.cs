using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqHomework.Enums;

namespace LinqHomework
{
    public class Car
    {
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public  Colors Color { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Horsepower { get; set; }
        public decimal KmUsed { get; set; }
        public Transmissions Transmission { get; set; }
        public decimal Price { get; set; }

    }
}
