using System.Collections.Generic;
using Model.Room;

namespace Controller.Room
{
    public static class ClientOnTable
    {
        public static Dictionary<Table, Client> clientAndTable = new Dictionary<Table, Client>(); // Usefull to know how many clients are in the room
    }
}
