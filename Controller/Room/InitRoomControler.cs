using System;
using System.Collections.Generic;
using Model.Room;

namespace Controller.Room
{
    class InitRoomControler
    {
        private InitRoomModel initRoomModel;
        private static InitRoomControler instance = null;
        private static readonly object padLock = new object();
        private InitRoomControler()
        {
            Init();
        }

        public static InitRoomControler Instance
        {
            get
            {
                lock (padLock)
                {
                    if (Instance == null)
                        instance = new InitRoomControler();
                    return instance;
                }
            }
        }


        //Create Lists :
        public List<Butler> butlerList { get; set; } = new List<Butler>{};
        public List<Client> clientList { get; set; } = new List<Client>{};
        public List<HeadWaiter> headWaiterList { get; set; } = new List<HeadWaiter>{};
        public List<ClerkRoom> clerkRoomList { get; set; } = new List<ClerkRoom>{};
        public List<Waiter> waiterList { get; set; } = new List<Waiter>{};


        public void Init()
        {
            //Initialize Actors
            InitBulter();
            InitHeadWaiter();
            InitClerkRoom();
            InitWaiter();

        }

        private void InitWaiter()
        {
            Waiter waiter1 = new Waiter("Waiter1", initRoomModel.squareList[0]);
            Waiter waiter2 = new Waiter("Waiter2", initRoomModel.squareList[0]);
            Waiter waiter3 = new Waiter("Waiter3", initRoomModel.squareList[1]);
            Waiter waiter4 = new Waiter("Waiter4", initRoomModel.squareList[1]);
        }

        private void InitClerkRoom()
        {
            ClerkRoom clerkRoom = new ClerkRoom("ClerkRoom");
            clerkRoomList.Add(clerkRoom);
        }

        private void InitHeadWaiter()
        {
            HeadWaiter headWaiter1 = new HeadWaiter("HeadWaiter1", initRoomModel.squareList[0]);
            HeadWaiter headWaiter2 = new HeadWaiter("HeadWaiter1", initRoomModel.squareList[1]);
            headWaiterList.Add(headWaiter1);
            headWaiterList.Add(headWaiter2);
        }

        private void InitBulter()
        {
            Butler butler = new Butler("butler");
            butlerList.Add(butler);
        }
    }
}
