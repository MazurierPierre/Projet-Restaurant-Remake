using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;

namespace Model.Kitchen.Storage
{
    public class Fridge : Storage
    {
        public Fridge() : base(5, 30, null)
        {
        }
    }
}
