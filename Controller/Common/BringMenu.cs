using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class BringMenu : IAct
    {
        private InitRoomModel initRoomModel;
        // TODO : Need to use thread
        public void act(Table table) // Bring the menu to the client
        {
            for (int i = 0; i < table.chairAmount; i++)
            {
                Card card = initRoomModel.cardList[i]; // Fetch the Card
                table.cardList.Add(card); // Add the card to the table
            }
            initRoomModel.cardList.RemoveRange(0, table.chairAmount); // Remove card from stock

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

        public void act(Table table, Waiter waiter)
        {
            throw new System.NotImplementedException();
        }

        public void act(Client client)
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
