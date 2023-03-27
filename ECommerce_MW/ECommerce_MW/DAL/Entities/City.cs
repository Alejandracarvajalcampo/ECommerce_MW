using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class City: Entity
    {
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = " El campo {0} deber ser {1} caracteres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Name { get; set; }

        public State State { get; set; }
    }
}
