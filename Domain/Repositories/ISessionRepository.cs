using StockTracker.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Domain.Repositories
{
    public interface ISessionRepository : IRepository <Entities.Session>
    {
        Task<IEnumerable<Entities.Session>> GetSessionByTicker(string ticker);
    }
}
