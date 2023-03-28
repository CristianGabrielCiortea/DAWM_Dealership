using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public double EngineSize { get; set; }

        public Color Color { get; set; }

        public FuelType FuelType { get; set; }

        public int SalesmanId { get; set; }
    }
}