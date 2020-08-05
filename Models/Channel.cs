using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IoTApps.Models
{
    public class Channel
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Channel Key")]
        [Required]
        public string Key { get; set; }

        [DisplayName("Channel Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Channel Description")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Field 1")]
        public string Field1 { get; set; }

        [DisplayName("Field 2")]
        public string Field2 { get; set; }

        [DisplayName("Field 3")]
        public string Field3 { get; set; }

        [DisplayName("Field 4")]
        public string Field4 { get; set; }

        [DisplayName("Field 5")]
        public string Field5 { get; set; }

        [DisplayName("Field 6")]
        public string Field6 { get; set; }

        [DisplayName("Field 7")]
        public string Field7 { get; set; }

        [DisplayName("Field 8")]
        public string Field8 { get; set; }
    }
}