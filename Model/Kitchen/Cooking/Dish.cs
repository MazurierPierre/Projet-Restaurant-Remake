using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking
{
    public class Dish
    {
        public Dish(string name, string description, List<Instruction> instructionsList, EnumKitchen.DishType dishType, EnumKitchen.DishState dishState)
        {
            this.name = name;
            this.description = description;
            this.instructionsList = instructionsList;
            this.dishType = dishType;
            this.dishState = dishState;
        }

        public string name { get; set; }
        public string description { get; set; }
        public List<Instruction> instructionsList { get; set; }
        public EnumKitchen.DishType dishType { get; set; }
        public EnumKitchen.DishState dishState { get; set; }
        



    }
}
