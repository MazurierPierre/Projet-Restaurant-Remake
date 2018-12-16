using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen;
using Model.Kitchen.Cooking;
using Model.Kitchen.Wash.Machines;
using Model.Room;
using Model.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class CleanKitchenware : IAct
    {
        public void act()
        {
            List<DishwasherMachine> DwMachineList = InitKitchen.Instance.dishwasherMachinesList;
            List<Sink> sinkList = InitKitchen.Instance.sinksList;
            DishwasherMachine DMUsing = null;
            Sink sinkUsing = null;

            //Premièrement on vérifie qu'une machine à laver est libre
            foreach (DishwasherMachine dishwasherMachine in DwMachineList)
            {
                if (!dishwasherMachine.isRunning)
                {
                    DMUsing = dishwasherMachine;
                    DMUsing.addToWash(InitKitchen.Instance.qkt1);
                    DMUsing.wash();
                    return;
                }
            }
            if (DMUsing == null)// Si toutes les machines à laver sont occupés - On va regarder si on peux utiliser un évier
            {
                foreach (Sink sink in sinkList)
                {
                    if (!sink.isRunning)
                    {
                        sinkUsing = sink;
                        sinkUsing.isRunning = true;
                        sinkUsing.addToWash(InitKitchen.Instance.qkt1);
                        return;
                    }
                }
            }
        }

        public void act(Client client, Table table)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.BreadType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.JugType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, Waiter waiter)
        {
            throw new NotImplementedException();
        }

        public void act(Client client)
        {
            throw new NotImplementedException();
        }

        public void act(Card card)
        {
            throw new NotImplementedException();
        }

        public void act(Client client, List<Menu> orderList)
        {
            throw new NotImplementedException();
        }
    }
}
