using System.ComponentModel.DataAnnotations;

namespace Envoycan_Application.Models
{
    public class UserRegistration_Model
    {
        [Key]
        [Display(Name ="ID")]
        public int UserID { get; set; }
        [Required(ErrorMessage ="Please Enter FirstName")]
        [Display(Name ="FirstName")]
        public string UserFirstName { get; set; }
        [Required(ErrorMessage ="Please Enter LastName")]
        [Display(Name ="LastName")]
        public string UserLastName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter Phone")]
        [DataType (DataType.PhoneNumber)]
        [Display(Name ="Phone Number")]
        public string Phone{ get; set; }

    }
}
