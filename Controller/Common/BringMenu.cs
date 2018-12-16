using Model.Room;

namespace Controller.Common
{
    public class BringMenu
    {
        private InitRoomModel initRoomModel;
        // TODO : Need to use thread
        public void voidAct(Table table) // Bring the menu to the client
        {
            for (int i = 0; i < table.chairAmount; i++)
            {
                Card card = initRoomModel.cardList[i]; // Fetch the Card
                table.cardList.Add(card); // Add the card to the table
            }
            initRoomModel.cardList.RemoveRange(0, table.chairAmount); // Remove card from stock

        }
    }
}
