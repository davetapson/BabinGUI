using IBApi;

namespace BabinGUI.BL.messages
{
    public enum TickType { BID = 1, ASK = 2, LAST = 4, HIGH = 6, LOW = 7, CLOSE = 9 };

    public class TickPrice
    {
        public TickPrice(int tickerId, int field, double price, TickAttrib tickAttribs)
        {
            TickerId = tickerId;
            Field = field;
            Price = price;
            TickAttribs = tickAttribs;
        }
        public int TickerId { get; set; }
        public int Field { get; set; }
        public double Price { get; set; }
        public TickAttrib TickAttribs { get; set; }         
    }
}
