using System.Collections.Generic;
using Controller.Room;
using Model.Room;

namespace Controller.Common
{
    public class CleanTable
    {
        // TODO: Need to use thread and locks

        public List<string> elementToClean = new List<string> { };
        public void voidAct(Table table, Waiter waiter) // Clean all the Element
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
    }
}
