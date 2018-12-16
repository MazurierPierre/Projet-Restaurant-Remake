namespace Model.Room
{
    public class PaymentTerminal
    {
        public int deskNumber { get; set; }
        public int nbClientPayed { get; set; }
        public PaymentTerminal(int deskNumber, int nbClientPayed)
        {
            this.deskNumber = deskNumber;
            this.nbClientPayed = nbClientPayed;
        }
    }
}
