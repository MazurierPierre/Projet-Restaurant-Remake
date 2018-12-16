using Controller.Room;
using Model.Room;

namespace Controller.Common
{
    public class AssignTable // : IAct // Give the client a table number
    {
        // TODO : Need to use Thread and the locks
        public void voidAct(Client client, Table table) // Assign a client to a table
        {
            PlaceClient placeClient = new PlaceClient();
            client.setTableNumber(table.tableNumber); // Give the table's number to the client
            table.state = "occupied";

            if (table.isReserved == true) // Remove reservation if assigned
            {
                table.isReserved = false;
            }
            placeClient.voidAct(client, table); // Place the client to the table
        }
    }
}
