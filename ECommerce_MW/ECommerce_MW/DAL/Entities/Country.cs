using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Country: Entity
    {
        [Display(Name = "País")]
        [MaxLength(50,ErrorMessage =" El campo {0} deber ser {1} caracteres")]
        [Required(ErrorMessage =" El campo {0} es obligatorio")]
        public string Name { get; set; }

        public ICollection<State> States { get; set; }
        public int StateNumber => States == null ? 0 : States.Count;
    }
}
