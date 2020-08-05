using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IoTApps.Models
{
    [Table ("ChannelData")]
    public class Data
    {
        [Key]
        public int IdData { get; set; }

        [DisplayName("Channel")]
        [Required]
        public int IdChannel { get; set; }
        [DisplayName("Field")]
        [Required]
        public int Field { get; set; }
        [DisplayName("Value")]
        [Required]
        public double Value { get; set; }
        [DisplayName("Date")]
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey ("IdChannel")]
        public Channel Channel { get; set; }
    }
}