using StockTracker.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Domain.Repositories
{
    public interface ICompanyRepository : IRepository <Entities.Company>
    {
        Task<IEnumerable<Entities.Company>> GetCompanyByTicker(string ticker);
    }
}
