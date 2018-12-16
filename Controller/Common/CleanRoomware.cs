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
    public class CleanRoomware : IAct
    {
        public void act()
        {
            //Après avoir modifié WashingMachine
            /*List<WashingMachine> DwMachineList = InitKitchen.Instance.washingMachinesList;
            WashingMachine WSUsing = null;

            //Premièrement on vérifie qu'une machine à laver est libre
            foreach (WashingMachine washingMachine in DwMachineList)
            {
                if (!washingMachine.isRunning)
                {
                    DMUsing.addToWash(InitKitchen.Instance.qkt1);
                    DMUsing.wash();
                    return;
                }
            }*/

        }
    }
}
