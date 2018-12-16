using System;
using Controller.Room;
using Model.Room;

namespace Controller.Common
{
    public class Pay 
    {
        //TODO : Take care of the threads
        private InitRoomModel initRoomModel;
        public void VoidAct(Client client, Table table)
        {
            // We don't manage the price of the dishes 
            // so we could think we just have to destroy the client's thread.
            Random rnd = new Random();
            for(int i = 0; i < initRoomModel.paymentTerminalsList.Count; i++)
            {
                int rndNumber = rnd.Next(0, initRoomModel.paymentTerminalsList.Count -1 ); // Generate a random number
                initRoomModel.paymentTerminalsList[rndNumber].incNbClientPaid(table.chairAmount); // Inc the nb of Client who paid
            }

            table.state = "free";
        }
    }
}
