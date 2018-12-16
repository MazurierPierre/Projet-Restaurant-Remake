using Model.Kitchen.Cooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen
{
    public class Counter
    {

        public Dish[] tabDish { get; set; }
        public int[] tableNumber { get; set; }

        public Counter()
        {
            this.tabDish = new Dish[15];
            this.tableNumber = new int[15]; //Va marquer la correspondance
        }

        public int actualLengthTab()
        {
            int cpt = 0;
            for (int i = 0; i < this.tabDish.Length; i++)
            {
                if (tabDish[i] != null)
                {
                    cpt++;
                }
            }
            return cpt;
        }

        public Boolean isTabFull()
        {
            if (actualLengthTab() >= this.tabDish.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*public Dictionary<int, Dish> mapCounter = new Dictionary<int, Dish>(); //Int < 16

        public void addCounter(int tableNumber, Dish dish)
        {
            if (this.mapCounter[tableNumber] == null && tableNumber < 16)
            {
                this.mapCounter[tableNumber] = dish;
            }         
        }

        public void removeFromCounter(int tableNumber)
        {
            this.mapCounter[tableNumber] = null;
        }

        public Boolean isCounterFull()
        {
            foreach (KeyValuePair<int, Dish> entry in this.mapCounter)
            {
                if (entry.Value == null) { return false; }
            }
            return true;
        }*/
    }
}
