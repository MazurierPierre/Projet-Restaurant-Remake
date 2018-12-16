using Controller.Interfaces;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class RemoveFromStocks : IAct
    {
        public void act()
        {
            throw new NotImplementedException();
        }
        public void act(Storage stor, int number, Ingredient ingredients)
        {
            stor.removeFromStorage(number, ingredients);
        }
    }
}
