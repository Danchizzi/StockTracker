using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : Repository<Domain.Entities.Company>, ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanyByTicker(string ticker)
        {
            throw new NotImplementedException();
        }
    }
}
