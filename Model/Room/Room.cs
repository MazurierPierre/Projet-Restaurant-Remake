using System.Collections.Generic;

namespace Model.Room
{
    public class Room
    {
        public int number { get; set; }
        public List<Square> squareList { get; set; }
        public List<PaymentTerminal> paymentTerminalList { get; set; }

        public Room(int number, List<Square> squareList, List<PaymentTerminal> paymentTerminalList)
        {
            this.number = number;
            this.squareList = squareList;
            this.paymentTerminalList = paymentTerminalList;
        }
    }
}
