using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IoTApps.Models
{
    [Table("Readings")]
    public class Readings
    {
        [Key]
        public int IdReading { get; set; }
        [Required]
        public int IdSensor { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public string Data { get; set; }
        [ForeignKey("IdSensor")]
        public Sensor Sensor { get; set; }
    }
}