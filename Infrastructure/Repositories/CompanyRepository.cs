using Infrastructure.Repositories.Base;
using StockTracker.Domain.Entities;
using StockTracker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : Repository<StockTracker.Domain.Entities.Company>, ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanyByTicker(string ticker)
        {
            throw new NotImplementedException();
        }
    }
}
