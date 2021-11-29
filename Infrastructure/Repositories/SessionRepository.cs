using StockTracker.Domain.Entities;
using StockTracker.Domain.Repositories;
using Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    class SessionRepository : Repository<StockTracker.Domain.Entities.Session>, ISessionRepository
    {
        public Task<IEnumerable<Session>> GetSessionByTicker(string ticker)
        {
            throw new NotImplementedException();
        }
    }
}
