using System.ComponentModel.DataAnnotations;

namespace GCIntranet.Models
{
    public class ContactInformation
    {
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "First name")]
        [Required, StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required, StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone number (including area code)")]
        [RegularExpression(@"^(\+?1-?)?(\([2-9]([02-9]\d|1[02-9])\)|[2-9]([02-9]\d|1[02-9]))-?[2-9]\d{2}-?\d{4}$",
            ErrorMessage = "Please specify a valid phone number")]
        [Required]
        public string Telephone { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code (Canada)")]
        [RegularExpression(@"(?i)^[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ] *\d[ABCEGHJKLMNPRSTVWXYZ]\d$",
            ErrorMessage = "Please specify a valid postal code")]
        [Required, StringLength(7)]
        public string PostalCode { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Website URL (https://www.url.com)")]
        public string Website { get; set; }
    }
}
