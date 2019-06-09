using CrmSalesProject.IRepositories;
using CrmSalesProject.Models;
using CrmSalesProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrmSalesProject.Repositories
{
    public class CrmSalesProjectRepository : ICrmSalesProjectRepository
    {
        private readonly CrmSalesProjectEntities _context;
        public CrmSalesProjectRepository()
        {
             _context = new CrmSalesProjectEntities();
        }
        public List<CrmAccountViewModel> GetAllAccounts()
        {
            var accounts = _context.CrmAccounts.ToList();
            List<CrmAccountViewModel> acList = new List<CrmAccountViewModel>();
            foreach(var account in accounts)
            {
                var crmAccountVm = new CrmAccountViewModel
                {
                    AccountId = account.AccountId,
                    AccountName = account.AccountName,
                    AccountNumber = account.AccountNumber,
                    VatNumber = account.VatNumber
                };
                acList.Add(crmAccountVm);
            }
            return acList;
        }
    }
}