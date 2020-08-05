using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoTApps.Models
{
    [Table("Sensors")]
    public class Sensor
    {
        [Key]
        public int IdSensor { get; set; }
        [Required]
        public int IdSource { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [ForeignKey("IdSource")]
        public Source Source { get; set; }
    }
}