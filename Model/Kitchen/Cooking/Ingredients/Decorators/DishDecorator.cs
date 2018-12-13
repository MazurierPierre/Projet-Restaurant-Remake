using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;

namespace Model.Kitchen.Cooking
{
    public abstract class DishDecorator : Dish
    {
        public DishDecorator(Dish originalDish) : base(originalDish.name, originalDish.description, originalDish.instructionsList, originalDish.dishType, originalDish.dishState)
        {

        }
    }
}
