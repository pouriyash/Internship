﻿using System.ComponentModel.DataAnnotations;

namespace Internship.Core.DomainModels.ViewModel.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [EmailAddress(ErrorMessage = "لطفا آدرس ایمیل معتبری را وارد نمائید.")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
    }
}