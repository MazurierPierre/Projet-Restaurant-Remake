using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;

namespace Model.Kitchen.Wash.Machines
{
    public class Sink : WashingKitchenTools
    {
        public Sink() : base(10, 30)
        {
        }
    }
}
