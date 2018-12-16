using Controller.Interfaces;
using Controller.Kitchen;
using Controller.Room;
using Model.Kitchen;
using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
using Model.Room;
using Model.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class AuthorizeOrder : IAct
    {
        public void act()
        {
            List<Cook> cookList = KitchenActorList.Instance.cookList;
            List<KitchenClerck> kitchenClercksList = KitchenActorList.Instance.kitchenClerkList;
            Cook theCook = null;
            KitchenClerck theKitchenClerck = null;
            //Selection des acteurs
            foreach (Cook cook in cookList)
            {
                if (cook.lockAction.Equals(false)) { theCook = cook; } //On choisis un cook disponible
            }
            foreach (KitchenClerck kc in kitchenClercksList)
            {
                if (kc.lockAction.Equals(false)) { theKitchenClerck = kc; } //On choisis un KC disponible
            }

            if ((theCook != null) && (theKitchenClerck != null)) //Si deux acteurs sont disponible
            {
                OrderTable orderTable = InitKitchen.Instance.orderTable;

                foreach (TMPOrder order in orderTable.orderList) //On consulte tous les order qui sont à faire
                    foreach (Menu menu in order.listeMenu)
                        foreach (Dish dish in menu.dishList)
                            foreach (Instruction instruction in dish.instructionsList)

                                //Utilisation du morning Dish à implémenter ici

                                if (instruction.kitchenAction.name.Equals("Chop Vegetables"))//Si nécessité de chop vegetables
                                {
                                    theKitchenClerck.action("ChopVegetables"); //Demander au comis de préparer le plat
                                }
                                else //Cook cuisine directement
                                {
                                    theCook.action("PrepareDish");
                                }
            }
            else
            {
                //Reesayer plus tard
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
