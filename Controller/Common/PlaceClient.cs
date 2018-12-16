using Controller.Room;
using Model.Room;

namespace Controller.Common
{
    public class PlaceClient : Interfaces.IAct
    {
        //public delegate void Del(Table table, EnumRoom.BreadType type);

        // TODO : Need to use thread, locks 
        public void act(Client client, Table table)
        {
            ClientOnTable.clientAndTable.Add(table, client); // Add the client in the list of client present in the room
            ClientQueue.clientList.Remove(client); // Remove the client of the queue
            client.tableNumber = table.tableNumber;

            /*
            BringBread bringBread = new BringBread();
            Del foo = new Del(bringBread.act);
            Thread bread = new Thread(() => foo(table, EnumRoom.BreadType.White));
            */
        }
    }
}
