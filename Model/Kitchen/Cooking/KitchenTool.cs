using Model.Kitchen.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking.Ingredients
{
    public class KitchenTool
    {
        public string name;
        public EnumKitchen.KitchenToolsType KitchenToolsType;

        public KitchenTool(string name, EnumKitchen.KitchenToolsType kitchenToolsType)
        {
            this.name = name;
            KitchenToolsType = kitchenToolsType;
        }
    }
}
