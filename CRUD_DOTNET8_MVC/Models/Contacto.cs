using System.ComponentModel.DataAnnotations;

namespace CRUD_DOTNET8_MVC.Models
{
    public class Contacto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Debe introducir un nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir un número de celular")]
        public string celular { get; set; }

        [Required(ErrorMessage = "Debe introducir un correo electrónico")]
        public string correo { get; set; }

        public DateTime fechaCreacion { get; set; }
    }
}
