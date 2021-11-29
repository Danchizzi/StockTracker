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
    class SessionRepository : Repository<Domain.Entities.Session>, ISessionRepository
    {
        public Task<IEnumerable<Session>> GetSessionByTicker(string ticker)
        {
            throw new NotImplementedException();
        }
    }
}
