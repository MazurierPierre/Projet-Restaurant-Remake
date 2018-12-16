using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class VerifyReservation : IAct
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

        // Useless
        public void act()
        {
            throw new System.NotImplementedException();
        }

        public void act(Client client, Table table)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, EnumRoom.BreadType type)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, EnumRoom.JugType type)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table)
        {
            throw new System.NotImplementedException();
        }

        public void act(Table table, Waiter waiter)
        {
            throw new System.NotImplementedException();
        }

        public void act(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void act(Client client, List<Menu> orderList)
        {
            throw new System.NotImplementedException();
        }
    }
}
