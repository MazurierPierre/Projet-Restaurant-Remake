using Controller.Interfaces;
using Controller.Kitchen;
using Model.Kitchen;
using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;
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

                foreach (TMPOrder order in orderTable.orderList) //On consulte tous les order qui sont à faire
                    foreach (Menu menu in order.listeMenu)
                        foreach (Dish dish in menu.dishList)
                            foreach (Instruction instruction in dish.instructionsList)
                                //wait 
                                //instruction.kitchenAction.duration()
                                dishreturn = new Dish(dish.name, dish.description, dish.instructionsList, dish.dishType, EnumKitchen.DishState.OK);
                                InitKitchen.Instance.dishReady.Add(new Tuple<Dish, int>(dishreturn, 1));

            }
        }
    }
}
