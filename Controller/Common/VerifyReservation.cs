using Controller.Room;
using Model.Room;

namespace Controller.Common
{
    public class VerifyReservation : Interfaces.IAct
    {
        public object BookingList { get; private set; }
        private InitRoomModel initRoomModel;
        public void act(Client client) // Verify if the client has a reservation
        {
            string name = client.name;

            foreach (BookingForm bookingForm in initRoomModel.bookingList) // Browse booking list
            {
                if (bookingForm.name == name) // If reservation founded :
                {
                    AssignTable assignTable = new AssignTable();
                    assignTable.act(client, bookingForm.table); // Assign the table to the client
                }
            }
        }
    }
}
