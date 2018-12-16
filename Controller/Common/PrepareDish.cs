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
    public class PrepareDish : IAct
    {
        public void act()
        {
            List<Cook> cookList = KitchenActorList.Instance.cookList;
            Cook theCook = null;
            Dish dishreturn = null;
            //Selection des acteurs
            foreach (Cook cook in cookList)
            {
                if (cook.lockAction.Equals(false)) { theCook = cook; } //On choisis un cook disponible
            }

            if ((theCook != null)) //Si deux acteurs sont disponible
            {
                OrderTable orderTable = InitKitchen.Instance.orderTable;

                foreach (Order order in orderTable.orderList)//On consulte tous les order qui sont à faire
                { 
                    foreach (Menu menu in order.orderList)
                    {
                        foreach (Dish dish in menu.dishList)
                        {
                            foreach (Instruction instruction in dish.instructionsList)
                            {
                                //wait le temps de l'instruction
                                
                                foreach(KitchenTool kt in instruction.kitchenToolsList)
                                {
                                    kt.KitchenToolsType = EnumKitchen.KitchenToolsType.Dirt;
                                    //InitKitchen.Instance.kitchenToolsList.Remove(kt);
                                    InitKitchen.Instance.qkt1.kitchenToolsList.Add(kt);
                                }
                                
                            }
                            dishreturn = new Dish(dish.name, dish.description, dish.instructionsList, dish.dishType, EnumKitchen.DishState.OK);
                            InitKitchen.Instance.dishReady.Add(new Tuple<Dish, int>(dishreturn, 1));
                        }
                    }
                }

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
