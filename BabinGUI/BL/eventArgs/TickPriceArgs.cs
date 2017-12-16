using BabinGUI.BL.messages;
using System;

namespace BabinGUI.BL.eventArgs
{
    public class TickPriceArgs : EventArgs
    {
        public TickPriceArgs(TickPrice tickPrice)
        {
            TickPrice = tickPrice;
        }
        public TickPrice TickPrice { get; set; }
    }
}
