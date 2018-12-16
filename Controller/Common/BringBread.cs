using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class BringBread : IAct
    {
        private InitRoomModel initRoomModel;
        // TODO : Need to take care of the DateBase and of the thread lock
        public void act(Table table, EnumRoom.BreadType type = EnumRoom.BreadType.White) // Bring bread
        {
            Bread bread = initRoomModel.breadList[0]; //Fetch a bread
            table.breadList.Add(bread); // Add the bread to the table
            initRoomModel.breadList.RemoveAt(0); //Remove the bread from stock
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
