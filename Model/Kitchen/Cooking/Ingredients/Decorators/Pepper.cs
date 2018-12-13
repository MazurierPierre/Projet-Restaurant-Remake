using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking
{
    public class Pepper : DishDecorator
    {
        public Pepper(Dish originalDish) : base(originalDish)
        {
            this.description += ", with pepper";
        }
    }
}
