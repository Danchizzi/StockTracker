using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Industry { get; set; }

        public string Ceo { get; set; }

        public string Sector { get; set; }

        public List<string> Tags { get; set; }

        public string FirstName { get; set; }

        public string Type { get; set; }
    }
}
