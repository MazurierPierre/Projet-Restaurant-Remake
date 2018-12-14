using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Enumerations
{
    public class EnumKitchen
    {
        public enum IngredientsType { Frozen, Fresh, Dry }
        public enum KitchenToolsType { OK, Dirt }
        public enum DishState { Preparing, OK, Eaten }
        public enum DishType { Entree, MainCourse, Dessert}
        public enum KitchenState { Clean, Dirt}
        public enum MachineType { Kitchen, Room, Launching }
    }
}
