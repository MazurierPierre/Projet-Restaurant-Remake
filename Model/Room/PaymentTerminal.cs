namespace Model.Room
{
    public class PaymentTerminal
    {
        public int deskNumber { get; set; }
        public int nbClientPaid { get; set; }
        public PaymentTerminal(int deskNumber, int nbClientPaid)
        {
            this.deskNumber = deskNumber;
            this.nbClientPaid = nbClientPaid;
        }

        public void incNbClientPaid(int i)
        {
            nbClientPaid = nbClientPaid + i;
        }
    }
}
