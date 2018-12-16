using System.Collections.Generic;
using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;

namespace Controller.Common
{
    public class CleanTable : IAct
    {
        // TODO: Need to use thread and locks

        public List<string> elementToClean = new List<string> { };
        public void act(Table table, Waiter waiter) // Clean all the Element
        {
            //Remove Bread
            for(int i = 0; i < table.breadList.Count; i++)
            {
                table.breadList[i] = null;
                elementToClean.Add("bread");
            }

            //Remove glass
            for (int i = 0; i < table.glassList.Count; i++)
            {
                table.glassList[i] = null;
                elementToClean.Add("glass");
            }

            //Remove Jug
            for (int i = 0; i < table.jugList.Count; i++)
            {
                table.jugList[i] = null;
                elementToClean.Add("jug");
            }

            //Remove plate
            for (int i = 0; i < table.plateList.Count; i++)
            {
                table.plateList[i] = null;
                elementToClean.Add("plate");
            }

            //Remove tablecloth
            table.tablecloth = null;
            elementToClean.Add("tablecloth");

            //Remove napkin
            for (int i = 0; i < table.napkinList.Count; i++)
            {
                table.napkinList[i] = null;
                elementToClean.Add("napkin");
            }

            int moveNeeded = (elementToClean.Count / 5) + 1; // Number of move between room and kitchen needed

            for (int i = 0; i < moveNeeded; i++) // Carry 5 items to kitchen and loop until done
            {
                waiter.communication.SendDirtyDishes(elementToClean[0]); // Use Socket to give to the kitchen the dirty dishes
                elementToClean.RemoveAt(0); // Remove element from list
            }
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

        public void act(Table table)
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
