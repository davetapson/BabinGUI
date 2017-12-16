using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabinGUI
{
    class BuyOrder
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public decimal Stop { get; set; }
        public decimal StopBuyLimit { get; set; }
        public decimal RiskPercent { get; set; }

    }
}
