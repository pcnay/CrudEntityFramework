using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
  public class Usuario
  {
    // Se agrega System.ComponentModel.DataAnnotations para que se active [key]
    [Key] // Es la llave de la tabla, estos on "DataAnnotations"
    public int Id { get; set; }
    [Required(ErrorMessage = "El Nombre es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El Telefono es obligatorio")]
    [Display (Name = "Telefono")]
    public string Telefono { get; set; }

    [Required(ErrorMessage = "El Celular es obligatorio")]
    [Display(Name = "Celular")]
    public string Celular { get; set; }

    [Required(ErrorMessage = "El Email es obligatorio")]
    [Display(Name = "Email")]
    public string Email { get; set; }

  }
}
