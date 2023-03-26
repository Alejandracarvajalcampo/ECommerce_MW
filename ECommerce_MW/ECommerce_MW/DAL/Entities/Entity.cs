using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de creacion")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de modificacion")]
        public DateTime? ModifiedDate { get; set;}
    }
}
