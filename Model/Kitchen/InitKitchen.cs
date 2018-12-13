using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
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
    public class InitKitchen
    {
        //Storage
        List<Ingredient> ingredientsForSupply;
        List<Ingredient> ingredientForFridge;
        List<Ingredient> ingredientForFreezer;
        List<Supply> supplyList;
        List<Freezer> freezersList;
        List<Fridge> fridgesList;

        //Cooking
        List<KitchenAction> kitchenActionsList;
        List<KitchenTool> kitchenToolsList;
        List<Instruction> instructionsList;
        List<Dish> dishesList;
        List<Menu> menusList;

        //Ingredients & cie
        Pepper peppersList;
        Salt saltsList;
        Cream creamsList;
        DishDecorator dishDecorator;

        //Wash
        List<QueueKitchenTools> queueKitchenToolsList;
        List<QueueRoomStuff> queueRoomToolsList;

        //Counter
        List<Counter> countersList;

        //OrderTable
        List<OrderTable> orderTablesList;

        //Equipment
        List<Oven> ovensList;
        List<KitchenFire> kitchenFiresList;

        //Wash
        List<Sink> sinksList;
        List<DishwasherMachine> dishwasherMachinesList;
        List<WashingMachine> washingMachinesList;

        //Kitchen
        Kitchen kitchen;

        public void Init()
        {
            //Initialise all objects
        }

        public void InitStorage()
        {
            //Fill storage with ingredientList
        }


    }
}
