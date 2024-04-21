using ECommerceAppTemplate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface ICompanyRepository: IGeneralRepository<Company>
    {
        void Update(Company company);
   
    }
}
