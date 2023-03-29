using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    internal class CarUpdateDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Make { get; set; }

        [Required, MaxLength(100)]
        public string Model { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public double EngineSize { get; set; }

        public Color Color { get; set; }

        public FuelType FuelType { get; set; }
    }
}
