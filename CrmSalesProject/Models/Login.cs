using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrmSalesProject.Models
{
    public class Login
    {
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="User id email is required")]
        public string CrmUserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name ="CRM Web service")]
        public string CrmWebServiceUrl { get; set; }
    }
}