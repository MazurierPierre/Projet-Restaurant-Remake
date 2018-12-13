using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;

namespace Model.Kitchen.Storage
{
    public class Freezer : Storage
    {
        public Freezer() : base(-20, 30, null)
        {

        }
    }
}
