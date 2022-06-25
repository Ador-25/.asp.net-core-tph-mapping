using System.ComponentModel.DataAnnotations;

namespace tph_mapping.Models
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        public double Lon { get; set; }
        public double Lan { get; set; }
        public string AddressDetails { get; set; }
    }
}
