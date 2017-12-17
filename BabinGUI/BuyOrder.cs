using System;

namespace GUI
{
    class BuyOrder
    {
        public BuyOrder(int id, string ticker, decimal stop, decimal stopBuyLimit, decimal? riskPercent, decimal? dollarValue, bool useRiskPercent, decimal priceOffSet)
        {
            if (id < 1) throw new ArgumentNullException("Id");
            if (string.IsNullOrWhiteSpace(ticker)) throw new ArgumentNullException("Ticker");
            if (stop <= 0) throw new ArgumentNullException("Stop");
            if (stopBuyLimit <= 0) throw new ArgumentNullException("StopBuyLimit");

            if (useRiskPercent == true) {
                if (riskPercent <= 0) throw new ArgumentNullException("RiskPercent");
                dollarValue = null;
            }
            else
            {
                if (dollarValue <= 0) throw new ArgumentNullException("DollarValue");
                riskPercent = null;
            }
            
            
            Id = id;
            Ticker = ticker;
            Stop = stop;
            StopBuyLimit = stopBuyLimit;
            RiskPercent = riskPercent;
            DollarValue = dollarValue;
            UseRiskPercent = useRiskPercent;
            PriceOffSet = priceOffSet;

        }

        public int Id { get; set; }
        public string Ticker { get; set; }
        public decimal Stop { get; set; }
        public decimal StopBuyLimit { get; set; }
        public decimal? RiskPercent { get; set; }
        public decimal? DollarValue { get; set; }
        public bool UseRiskPercent { get; set; }
        public decimal PriceOffSet { get; set; }
        public int CurrentPositionSize { get; set; }
        public decimal CurrentPrice { get; internal set; }
        public decimal Low { get; set; } = -1;
        public string OrderStatus { get; set; } = "Pending"; // todo enum class
    }
}
