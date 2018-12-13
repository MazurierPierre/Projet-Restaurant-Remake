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
        public Dish[] dishTable = new Dish[15];
        public int[] nbTable = new int[15];

        public Counter(Dish[] dishTable, int[] nbTable)
        {
            this.dishTable = dishTable;
            this.nbTable = nbTable;
        }

        public Boolean isTabFull()
        {
            return true;
        }

        public int actualLength()
        {
            return 1;
        }

    }
}
