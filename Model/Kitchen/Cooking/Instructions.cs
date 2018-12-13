using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Equipment;

namespace Model.Kitchen.Cooking.Ingredients
{
    public class Instruction
    {
        public Instruction(int number, string description, List<KitchenTool> kitchenToolsList, List<Ingredient> ingredientsList, KitchenAction kitchenAction, Equipments equipment)
        {
            this.number = number;
            this.description = description;
            this.kitchenToolsList = kitchenToolsList;
            this.ingredientsList = ingredientsList;
            this.kitchenAction = kitchenAction;
            this.equipment = equipment;
        }

        public int number { get; set; }
        public string description { get; set; }
        public List<KitchenTool> kitchenToolsList { get; set; }
        public List<Ingredient> ingredientsList { get; set; }
        public KitchenAction kitchenAction { get; set; }
        public Equipments equipment { get; set; }


    }
}
