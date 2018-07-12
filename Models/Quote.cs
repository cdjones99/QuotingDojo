using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{

    public class Quote
    {
        [Required(ErrorMessage="User is Required.")]
        [MinLength(2,ErrorMessage="Username must be at least two characters.")]
        [Display(Name="Name")]
        public string user {get;set;}
        [Required(ErrorMessage="Quote is required.")]
        [MinLength(4, ErrorMessage="Quote must be at least four characters.")]
        [Display(Name="Quote")]
        public string text{get;set;}
    }

}