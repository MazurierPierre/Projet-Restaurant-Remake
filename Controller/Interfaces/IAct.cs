using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Interfaces
{
    public interface IAct
    {
        void act();
        void act(Client client, Table table);
        void act(Table table, EnumRoom.BreadType type);
        void act(Table table, EnumRoom.JugType type);
        void act(Table table);
        void act(Table table, Waiter waiter);
        void act(Client client);
        void act(Card card);
        void act(Client client, List<Menu> orderList);
    }
}
