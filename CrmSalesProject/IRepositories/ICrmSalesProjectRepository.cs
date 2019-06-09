using CrmSalesProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmSalesProject.IRepositories
{
    public interface ICrmSalesProjectRepository
    {
        List<CrmAccountViewModel> GetAllAccounts();

    }
}
