using Controller.Interfaces;
using Model.Kitchen;
using Model.Kitchen.Wash.Machines;
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
    }
}
