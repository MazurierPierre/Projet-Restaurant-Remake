using Model.Kitchen.Enumerations;
using Model.Kitchen.Equipment;
using Model.Kitchen.Storage;
using Model.Kitchen.Wash.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen
{
    public class Kitchen
    {
        public EnumKitchen.KitchenState kitchenState { get; set; }

        //All physicals objects contained into Kitchen 

        public Counter counter { get; set; }
        //stocks
        public List<Fridge> fridgesList { get; set; }
        public List<Freezer> freezersList { get; set; }
        public List<Supply> suppliesList { get; set; }
        //Wash
        public List<Sink> sinksList { get; set; }
        public List<DishwasherMachine> dishwasherMachinesList { get; set; }
        public List<WashingMachine> washingMachinesList { get; set; }
        //Equipment
        public List<KitchenFire> kitchenFiresList { get; set; }
        public List<Oven> ovensList { get; set; }


    }
}
