using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestConsume.Models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Contact Number ")]
        [Required(ErrorMessage = "Name is required")]
        public string Contact { get; set; }

        [Display(Name = "Profile Pic URL")]
        [Required(ErrorMessage = "Profile Pic URL is required")]
        public string Profilepic { get; set; }


        [Display(Name = "TotalInvestment ")]
        [Required(ErrorMessage = "TotalInvestment is required")]
        public string Totalinvestment { get; set; }

        public string Gender { get; set; }
    }
}
