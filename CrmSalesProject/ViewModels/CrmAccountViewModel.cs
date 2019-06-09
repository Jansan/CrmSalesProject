using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmSalesProject.ViewModels
{
    public class CrmAccountViewModel
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string VatNumber { get; set; }
    }
}