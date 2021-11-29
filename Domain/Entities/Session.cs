using StockTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Domain.Entities
{
    public class Session
    {
        public int SessionId{ get; set; }

        public Status Status { get; set; }

        public DateTime From { get; set; }

        public string Symbol { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public double Volume { get; set; }

        public double AfterHours { get; set; }

        public double PreMarket { get; set; }
    }
}
