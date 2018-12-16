using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class KitchenActorList
    {
        private static KitchenActorList instance = null;
        private static readonly object padLock = new object();
        private KitchenActorList()
        {

        }

        public static KitchenActorList Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                        instance = new KitchenActorList();
                    return instance;
                }
            }
        }

        public List<MainChef> mainChefList { get; set; } = new List<MainChef>();
        public List<Cook> cookList { get; set; } = new List<Cook>();
        public List<KitchenClerck> kitchenClerkList { get; set; } = new List<KitchenClerck>();
        public List<DishWasher> dishwasherList { get; set; } = new List<DishWasher>();
        public MainChef mainChef1 { get; set; } = new MainChef("Emiliano del restaurante");
        public Cook cook1 = new Cook("Gilly el cook");
        public KitchenClerck kitchenClerck1 = new KitchenClerck("Maz el banador");
        public DishWasher dishWasher1 = new DishWasher("Gilly el dishwasher");


        public void init()
        {
            mainChefList.Add(mainChef1);
            cookList.Add(cook1);
            kitchenClerkList.Add(kitchenClerck1);
            dishwasherList.Add(dishWasher1);
        }
    }
}
