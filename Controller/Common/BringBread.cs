using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class BringBread //: IAct
    {
        private InitRoomModel initRoomModel;
        // TODO : Need to take care of the DateBase and of the thread lock
        public void voidAct(Table table, EnumRoom.BreadType type = EnumRoom.BreadType.White) // Bring bread
        {
            Bread bread = initRoomModel.breadList[0]; //Fetch a bread
            table.breadList.Add(bread); // Add the bread to the table
            initRoomModel.breadList.RemoveAt(0); //Remove the bread from stock
        }
    }
}
