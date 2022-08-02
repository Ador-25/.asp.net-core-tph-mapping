using System.ComponentModel.DataAnnotations;

namespace tph_mapping.Models
{
    public class UserAccount
    {
        [Key]
        public Guid AccountId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Address? UserAddress { get; set; }

        //add tpt class here for double check
        //multiple inheritance needed for address
        //check if tpt allowed here
    }
}
