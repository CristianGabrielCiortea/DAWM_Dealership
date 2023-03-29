using System.ComponentModel.DataAnnotations;

namespace Core.Dtos
{
    public class SalesmanUpdteDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }
    }
}