using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class BringJug 
    {
        // TODO : Need to take care of the DateBase and of the thread lock
        private InitRoomModel initRoomModel;
        public void voidAct(Table table, EnumRoom.JugType type = EnumRoom.JugType.Tap) // Bring Water
        {
            Jug jug = initRoomModel.jugList[0]; // Fetch a Jug
            table.jugList.Add(jug); // Add the Jug to the table
            initRoomModel.jugList.RemoveAt(0); //Remove the Jug from stock
        }
    }
}
