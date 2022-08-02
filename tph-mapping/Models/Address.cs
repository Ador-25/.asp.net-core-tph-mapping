using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace tph_mapping.Models
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        public double Lon { get; set; }
        public double Lan { get; set; }
        public string AddressDetails { get; set; }
        public Guid AccountRef { get; set; }
        [JsonIgnore]
        public UserAccount UserAccount { get; set; }
    }
}
