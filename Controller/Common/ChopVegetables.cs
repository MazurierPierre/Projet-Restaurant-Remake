using Controller.Interfaces;
using Controller.Kitchen;
using Controller.Room;
using Model.Kitchen;
using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;
using Model.Room;
using Model.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class ChopVegetables : IAct
    {
        public void act()
        {
            List<KitchenClerck> KCList = KitchenActorList.Instance.kitchenClerkList;
            KitchenClerck theKC = null;
            Dish dishreturn = null;
            //Selection des acteurs
            foreach (KitchenClerck kc in KCList)
            {
                if (kc.lockAction.Equals(false)) { theKC = kc; } //On choisis un KC disponible
            }

            if ((theKC != null))
            {
                OrderTable orderTable = InitKitchen.Instance.orderTable;

                foreach (Order order in orderTable.orderList) //On consulte tous les order qui sont à faire
                    foreach (Menu menu in order.orderList)
                        foreach (Dish dish in menu.dishList)
                            foreach (Instruction instruction in dish.instructionsList)
                                //wait 
                                //instruction.kitchenAction.duration()
                                dishreturn = new Dish(dish.name, dish.description, dish.instructionsList, dish.dishType, EnumKitchen.DishState.OK); //Must be "Chop Vegetables"
                                InitKitchen.Instance.dishReady.Add(new Tuple<Dish, int>(dishreturn, 1));
            }
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
