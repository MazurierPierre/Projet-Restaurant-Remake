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
        public Dictionary<int,Dish> mapCounter; //Int < 16

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
        }
    }
}
