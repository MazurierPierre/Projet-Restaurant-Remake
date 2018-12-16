using Controller.Room;

namespace Controller.Common
{
    public class Eat : Interfaces.IAct
    {
        // Because we don't have time to finish the clock i can't manage the speed increase
        public void act(Client client) // Allow the client to eat and so spend a specific time
        {
            if (client.behavior == "Relaxed")
            {
                System.Threading.Thread.Sleep(30000); // Wait 30 seconds 


            }
            else if (client.behavior == "StressedOut")
            {
                System.Threading.Thread.Sleep(200000);// Wait 200 seconds 

            }
        }
    }
}
