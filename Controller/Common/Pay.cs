using System;
using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class Pay : IAct
    {
        //TODO : Take care of the threads
        private InitRoomModel initRoomModel;
        public void act(Client client, Table table)
        {
            // We don't manage the price of the dishes 
            // so we could think we just have to destroy the client's thread.
            Random rnd = new Random();
            for(int i = 0; i < initRoomModel.paymentTerminalsList.Count; i++)
            {
                int rndNumber = rnd.Next(0, initRoomModel.paymentTerminalsList.Count -1 ); // Generate a random number
                initRoomModel.paymentTerminalsList[rndNumber].incNbClientPaid(table.chairAmount); // Inc the nb of Client who paid
            }

            table.state = "free";
        }

        // Useless
        public void act()
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.BreadType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.JugType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, Waiter waiter)
        {
            throw new NotImplementedException();
        }

        public void act(Client client)
        {
            throw new NotImplementedException();
        }

        public void act(Card card)
        {
            throw new NotImplementedException();
        }

        public void act(Client client, List<Menu> orderList)
        {
            throw new NotImplementedException();
        }
    }
}
