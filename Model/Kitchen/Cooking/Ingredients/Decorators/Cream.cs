﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;

namespace Model.Kitchen.Cooking
{
    public class Cream : DishDecorator
    {
        public Cream(Dish originalDish) : base(originalDish)
        {
            this.description += ", with cream";
        }
    }
}
