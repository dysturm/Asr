using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.ViewModels
{
    public class TestTableViewModel
    {
        [Required(ErrorMessage = "Enter First Name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}