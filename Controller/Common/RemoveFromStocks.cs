using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Storage;
using Model.Room;
using Model.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class RemoveFromStocks : IAct
    {
        public void act()
        {
            throw new NotImplementedException();
        }
        public void act(Storage stor, int number, Ingredient ingredients)
        {
            stor.removeFromStorage(number, ingredients);
        }

        public void act(Client client, Table table)
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
