using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        String email { get; set; };

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        String ConfirmPassword { get; set; }

    }
}
