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
        public Kitchen(EnumKitchen.KitchenState kitchenState, Counter counter, OrderTable orderTable, List<Fridge> fridgesList, List<Freezer> freezersList, List<Supply> suppliesList, List<Sink> sinksList, List<DishwasherMachine> dishwasherMachinesList, List<WashingMachine> washingMachinesList, List<KitchenFire> kitchenFiresList, List<Oven> ovensList)
        {
            this.kitchenState = kitchenState;
            this.counter = counter;
            this.orderTable = orderTable;
            this.fridgesList = fridgesList;
            this.freezersList = freezersList;
            this.suppliesList = suppliesList;
            this.sinksList = sinksList;
            this.dishwasherMachinesList = dishwasherMachinesList;
            this.washingMachinesList = washingMachinesList;
            this.kitchenFiresList = kitchenFiresList;
            this.ovensList = ovensList;
        }

        public EnumKitchen.KitchenState kitchenState { get; set; }

        //All physicals objects contained into Kitchen 

        public Counter counter { get; set; }
        public OrderTable orderTable { get; set; }
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
