using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Kitchen;
using Controller.Kitchen;
using Model.Room;
using Model.Kitchen.Cooking;
using Model.Kitchen.Enumerations;
using Model.Kitchen.Cooking.Ingredients;

namespace Unit_Tests
{
    /// <summary>
    /// Summary description for KitchenTest
    /// </summary>
    [TestClass]
    public class KitchenTest
    {
        public KitchenTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

            [TestInitialize]
            public void InitiKitchen()
        {
            //Kitchen auto initialised because of Singleton
            var init = InitKitchen.Instance;
            init.Init();
            var initPersonnel = KitchenActorList.Instance;
            initPersonnel.init();
        }

        [TestMethod]
        public void CompletScenarioTest()
        {
            
            OrderTable orderTable = InitKitchen.Instance.orderTable;
            Order order1 = new Order(InitKitchen.Instance.menusList, 1); //Commande pour la table 1
            orderTable.orderList.Add(order1);
            //Contient : 
            // cuttedCarrots = new Dish("Cutted Carrot", "Carrots cutted", instructionsForEntree, EnumKitchen.DishType.Entree, EnumKitchen.DishState.Preparing);
            //cookedCarrot = new Dish("Cooked carrot", "Delicious cooked carrots", instructionsForMainCourse, EnumKitchen.DishType.MainCourse, EnumKitchen.DishState.Preparing);

            KitchenActorList.Instance.mainChef1.action("AuthorizeOrder");

            Assert.AreEqual(InitKitchen.Instance.dishReady.Count, 2);
            foreach(Tuple<Dish,int> dish in InitKitchen.Instance.dishReady)
            {
                Assert.AreEqual(dish.Item1.dishState, EnumKitchen.DishState.OK);
                Assert.AreEqual(dish.Item2,1); //Pour la table 1
            }

            //wash
            KitchenTool lastKitchenTool = null;
            foreach(KitchenTool kt in InitKitchen.Instance.qkt1.kitchenToolsList)
            {
                Assert.AreEqual(kt.KitchenToolsType, EnumKitchen.KitchenToolsType.Dirt); //Outils go plonge
                lastKitchenTool = kt;
            }
            Assert.AreEqual(lastKitchenTool.name, "pan"); //Dernier outil de la liste

            KitchenActorList.Instance.dishWasher1.action("CleanKitchenware");

            foreach (KitchenTool kt in InitKitchen.Instance.kitchenToolsList)
            {
                Assert.AreEqual(kt.KitchenToolsType, EnumKitchen.KitchenToolsType.OK); //On récupère nos outils
            }

            //Counter
            KitchenActorList.Instance.kitchenClerck1.action("BringMealToCounter");

            Assert.AreEqual(InitKitchen.Instance.counter.tabDish[0].name, "Cutted Carrot");
            Assert.AreEqual(InitKitchen.Instance.counter.tabDish[0].dishState, EnumKitchen.DishState.OK);
            Assert.AreEqual(InitKitchen.Instance.counter.tableNumber[0],1);
            Assert.AreEqual(InitKitchen.Instance.counter.tabDish[1].name, "Cooked carrot");
            Assert.AreEqual(InitKitchen.Instance.counter.tabDish[1].dishState, EnumKitchen.DishState.OK);
            Assert.AreEqual(InitKitchen.Instance.counter.tableNumber[1], 1);
        }
    }
}
