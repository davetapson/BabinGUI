namespace BabinGUI.BL.messages
{
    public class MarketRuleIncrement
    {
        private decimal increment;

        public MarketRuleIncrement(decimal lowEdge, decimal increment)
        {
            LowEdge = lowEdge;
            PriceIncrement = increment;
        }

        public decimal LowEdge { get; set; }
        public decimal PriceIncrement { get; set; }
    }
}
