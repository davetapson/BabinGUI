using BabinGUI.BL.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class MarketRuleArgs : EventArgs
    {
        public MarketRuleArgs(MarketRule marketRule)
        {
            MarketRule = marketRule;
        }

        public MarketRule MarketRule { get; }
    }
}
