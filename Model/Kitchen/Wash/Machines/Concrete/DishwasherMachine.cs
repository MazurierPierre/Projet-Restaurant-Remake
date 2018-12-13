using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;

namespace Model.Kitchen.Wash.Machines
{
    public class DishwasherMachine : WashingKitchenTools
    {
        public DishwasherMachine() : base(10, 30)
        {
        }
    }
}
