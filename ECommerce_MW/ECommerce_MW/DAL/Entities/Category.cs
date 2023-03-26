using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Category: Entity
    {
        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = " El campo {0} deber ser {1} caracteres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}
