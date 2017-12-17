using System.Collections.Generic;

namespace BabinGUI.BL.messages
{
    public class MarketRule
    {
        public int MarketRuleId { get; set; }
        public List<MarketRuleIncrement> MarketRuleIncrements { get; set; }
    }
}
