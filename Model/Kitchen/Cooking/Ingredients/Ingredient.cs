using Model.Kitchen.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking.Ingredients
{
    public class Ingredient
    {
        public Ingredient(string name, EnumKitchen.IngredientsType ingredientsType, DateTime deliveryDate, DateTime expirationDate)
        {
            this.name = name;
            this.ingredientsType = ingredientsType;
            this.deliveryDate = deliveryDate;
            this.expirationDate = expirationDate;
        }

        public string name { get; set; }
        public EnumKitchen.IngredientsType ingredientsType { get; set; }
        public DateTime deliveryDate { get; set; }
        public DateTime expirationDate { get; set; }


    
    }
}
