using Model.Kitchen.Cooking;
using Model.Kitchen.Cooking.Ingredients;
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
    public class InitKitchen
    {

        public void Init()
        {
            //Initialise all objects
            InitIngredient(); //Create all ingredients & ingredientList
            InitStorage(); //Fill storage with ingredientList
            InitEquipment(); //Create all equipments that will be in kitchen
            InitToolsAndActions(); //Initialise everything to cook

            //Menus
            InitialiseMenu1(); //Set menu n°1 - Cuted & cooked carrot

            InitQueue(); //Initialise WashQueue
            InitWashMachine(); //Washmachine & overs

            InitKitchenObject(); //The kitchen itself

        }

        /* =====================================INGREDIENT===================================*/

        private List<Ingredient> ingredientForFridge;
        public Ingredient carrot { get; set; } = new Ingredient("Carrot", EnumKitchen.IngredientsType.Fresh, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        public Ingredient broccoli { get; set; } = new Ingredient("Broccoli", EnumKitchen.IngredientsType.Fresh, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        public Ingredient potato { get; set; } = new Ingredient("Potato", EnumKitchen.IngredientsType.Fresh, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        private List<Ingredient> ingredientsForSupply;
        public Ingredient apple { get; set; } = new Ingredient("Apple", EnumKitchen.IngredientsType.Dry, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        public Ingredient perry { get; set; } = new Ingredient("Perry", EnumKitchen.IngredientsType.Dry, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        public Ingredient rice { get; set; } = new Ingredient("Rice", EnumKitchen.IngredientsType.Dry, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        private List<Ingredient> ingredientForFreezer;
        public Ingredient pasta { get; set; } = new Ingredient("Pasta", EnumKitchen.IngredientsType.Frozen, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));
        public Ingredient pizza { get; set; } = new Ingredient("Pizza", EnumKitchen.IngredientsType.Frozen, new DateTime(2018, 1, 18), new DateTime(2018, 1, 30));

        //Ingredients & cie
        public Pepper pepper { get; set; }
        public Salt salt { get; set; }
        public Cream cream { get; set; }
        public DishDecorator dishDecorator { get; set; }

        public void InitIngredient() {
            //Fresh
            ingredientForFridge.Add(carrot);
            ingredientForFridge.Add(broccoli);
            ingredientForFridge.Add(potato);
            //Dry
            ingredientsForSupply.Add(apple);
            ingredientsForSupply.Add(perry);
            ingredientsForSupply.Add(rice);
            //Freez
            ingredientForFreezer.Add(perry);
            ingredientForFreezer.Add(rice);
        }

        /* ======================================STORAGE===================================== */

        public List<Supply> supplyList { get; set; }
        public List<Freezer> freezersList { get; set; }
        public List<Fridge> fridgesList { get; set; }
        public Supply supply1 { get; set; } = new Supply();
        public Fridge fridge1 { get; set; } = new Fridge();
        public Freezer freezer1 { get; set; } = new Freezer();

        public void InitStorage()
        {
            //Création des objets - On pourrait en imaginer plusieurs
            supplyList.Add(supply1);
            fridgesList.Add(fridge1);
            freezersList.Add(freezer1);

            //Initialisation des Supply
            foreach (Supply suply in supplyList)
            {
                foreach (Ingredient ingredient in ingredientsForSupply)
                {
                    suply.ingredientsList.Add(ingredient);
                }
            }
            //Initialisation des Fridge
            foreach (Fridge fridge in fridgesList)
            {
                foreach (Ingredient ingredient in ingredientForFridge)
                {
                    fridge.ingredientsList.Add(ingredient);
                }
            }
            //Initialisation des Freezer
            foreach (Freezer freezer in freezersList)
            {
                foreach (Ingredient ingredient in ingredientForFreezer)
                {
                    freezer.ingredientsList.Add(ingredient);
                }
            }

        }
        /* ======================================EQUIPMENT===================================== */

        //Equipment
        public List<Oven> ovensList { get; set; }
        public List<KitchenFire> kitchenFiresList { get; set; }
        public Oven oven1 { get; set; } = new Oven("Oven1");
        public Oven oven2 { get; set; } = new Oven("Oven2");
        public KitchenFire kf1 { get; set; } = new KitchenFire("kf1");
        public KitchenFire kf2 { get; set; } = new KitchenFire("kf2");

        public void InitEquipment()
        {
            ovensList.Add(oven1);
            ovensList.Add(oven2);

            kitchenFiresList.Add(kf1);
            kitchenFiresList.Add(kf2);
        }


        /* ======================================COOKING===================================== */
        //List
        public List<KitchenAction> kitchenActionsList { get; set; }
        public List<KitchenTool> kitchenToolsList { get; set; }

        public List<Dish> dishesList { get; set; }
        public List<Menu> menusList { get; set; }
        //KitchenAction
        public KitchenAction cut { get; set; } = new KitchenAction("cut", 5);
        public KitchenAction slice { get; set; } = new KitchenAction("slice", 5);
        public KitchenAction mince { get; set; } = new KitchenAction("mince", 5);
        public KitchenAction chop { get; set; } = new KitchenAction("chop", 5);
        public KitchenAction grind { get; set; } = new KitchenAction("grind", 5);
        public KitchenAction shred { get; set; } = new KitchenAction("shred", 5);
        public KitchenAction peel { get; set; } = new KitchenAction("peel", 5);
        public KitchenAction grill { get; set; } = new KitchenAction("grill", 5);
        //KitchenTools
        public KitchenTool whisk { get; set; } = new KitchenTool("whisk", EnumKitchen.KitchenToolsType.OK); //fouet
        public KitchenTool woodenSpoon { get; set; } = new KitchenTool("wooden Spoon", EnumKitchen.KitchenToolsType.OK);
        public KitchenTool knife { get; set; } = new KitchenTool("knife", EnumKitchen.KitchenToolsType.OK);
        public KitchenTool pan { get; set; } = new KitchenTool("pan", EnumKitchen.KitchenToolsType.OK);


        //Menu1
        public Dish cuttedCarrots { get; set; }
        public Dish cookedCarrot { get; set; } //Main course
        //Dessert ?
        public Menu menu1 { get; set; }

        public void InitToolsAndActions()
        {
            //[...] KitchenAction
            kitchenActionsList.Add(cut);
            kitchenActionsList.Add(slice);
            kitchenActionsList.Add(mince);
            kitchenActionsList.Add(chop);
            kitchenActionsList.Add(grind);
            kitchenActionsList.Add(shred);
            kitchenActionsList.Add(peel);
            kitchenActionsList.Add(grill);

            //[...] KitchenTools
            kitchenToolsList.Add(whisk);
            kitchenToolsList.Add(woodenSpoon);
            kitchenToolsList.Add(knife);
            kitchenToolsList.Add(pan);
        }
        public void InitialiseMenu1() {
            //InstructionList
            List<Ingredient> ingredientsNeededForInstruction1 = new List<Ingredient>
            {
                carrot,
                carrot
            };
            Instruction cutTheCarrotInstruction1 = new Instruction(1, "cut the carrot", kitchenToolsList, ingredientsNeededForInstruction1, cut, null);
            Instruction cookTheCarrotInstruction2 = new Instruction(2, "cook the carrot", kitchenToolsList, ingredientsNeededForInstruction1, cut, oven1);
            List<Instruction> instructionsForEntree = new List<Instruction>
            {
                cutTheCarrotInstruction1,
            };
            List<Instruction> instructionsForMainCourse = new List<Instruction>
            {
                cutTheCarrotInstruction1,
                cookTheCarrotInstruction2
            };

            cuttedCarrots = new Dish("Cutted Carrot", "Carrots cutted", instructionsForEntree, EnumKitchen.DishType.Entree, EnumKitchen.DishState.Preparing);
            cookedCarrot = new Dish("Cooked carrot", "Delicious cooked carrots", instructionsForMainCourse, EnumKitchen.DishType.MainCourse, EnumKitchen.DishState.Preparing);

            List<Dish> listDishForMenu1 = new List<Dish>
            {
                cuttedCarrots,
                cookedCarrot
            };

            menu1 = new Menu("Menu 1 - Cooked Carrot", listDishForMenu1, true);
        }

        /* ======================================WASH===================================== */
        public List<QueueKitchenTools> queueKitchenToolsList { get; set; }
        public List<QueueRoomStuff> queueRoomToolsStuff { get; set; }

        public QueueKitchenTools qkt1 { get; set; } = new QueueKitchenTools(null);
        public QueueRoomStuff qrts1 { get; set; } = new QueueRoomStuff();// ==> Waiting gilly

        public void InitQueue()
        {
            queueKitchenToolsList.Add(qkt1);
            queueRoomToolsStuff.Add(qrts1);
        }

        public List<Sink> sinksList { get; set; }
        public List<DishwasherMachine> dishwasherMachinesList { get; set; }
        public List<WashingMachine> washingMachinesList { get; set; }
        public Sink sink1 { get; set; } = new Sink();
        public Sink sink2 { get; set; } = new Sink();
        public DishwasherMachine dishwasherMachine1 { get; set; } = new DishwasherMachine();
        public WashingMachine washMachine1 { get; set; } = new WashingMachine();

        public void InitWashMachine()
        {
            sinksList.Add(sink1);
            sinksList.Add(sink2);

            dishwasherMachinesList.Add(dishwasherMachine1);

            washingMachinesList.Add(washMachine1);
        }

        /* ======================================COUNTER & ORDER TABLE===================================== */
        //Counter
        public Counter counter { get; set; } = new Counter();
        //OrderTable
        public OrderTable orderTable { get; set; } = new OrderTable();

        /* ======================================KITCHEN===================================== */

        //Kitchen
        public Kitchen kitchen { get; set; }

        public void InitKitchenObject()
        {
            kitchen = new Kitchen(EnumKitchen.KitchenState.Clean, counter,orderTable, fridgesList, freezersList, supplyList, sinksList, dishwasherMachinesList, washingMachinesList, kitchenFiresList, ovensList);
        }
        
    }
}


