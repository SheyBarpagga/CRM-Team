using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_Team.Models
{
    public class RenterService
    {
        [Key]
        [Required]
        [ForeignKey("Service_ID")]
        public Guid Service_ID { get; set; }

        public virtual Service Service { get; set; }

        [Key]
        [Required]
        [ForeignKey("Renter_ID")]
        public Guid Renter_ID { get; set; }

        public string Date { get; set; }
        public float Actual_Hours { get; set; }
    }
}
