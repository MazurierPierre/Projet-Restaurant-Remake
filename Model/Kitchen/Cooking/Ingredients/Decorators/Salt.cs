using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking
{
    public class Salt : DishDecorator
    {
        public Salt(Dish originalDish) : base(originalDish)
        {
            this.description += ", with salt";
        }
    }
}
