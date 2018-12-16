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
    public class CheckStocks : IAct
    {
        public void act()
        {
            //Not implemented
        }

        public List<Ingredient> act(Storage stor)
        {
            return stor.chechStorage();
        }
    }
}
