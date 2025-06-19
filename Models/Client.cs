using System.ComponentModel.DataAnnotations;

namespace GestionSalleDeMariage.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telephone { get; set; }
    }
} 