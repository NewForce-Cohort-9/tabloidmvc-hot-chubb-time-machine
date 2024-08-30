using System.ComponentModel;

namespace TabloidMVC.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName ("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        public string Email { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreateDateTime { get; set; }

        public string ImageLocation { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
