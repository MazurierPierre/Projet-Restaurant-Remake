using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Controller.Time
{
    public class Clock : Interfaces.Clock, IObservable<Clock>
    {
        // Single instance of clock (Usefull for Singleton pattern)
        private static Clock instance = null;

        // Lock access to instance
        private static readonly object padlock = new object();

        // Is incremented at every clock tick
        private long tickCount;

        // Self explanatory ...
        private int timeBetweenTicks;

        // Timer component
        private Timer t;

        // Self explanatory ...
        public bool isStarted { get; set; }
        public bool isRestaurantOpen { get; set; }

        // List of objects which observe the clock
        private List<IObserver<Clock>> observers;

        private Clock()
        {
            // Setting default values
            tickCount = 0;
            timeBetweenTicks = 1000;

            // Creating & configuring timer component
            t = new Timer();
            t.Interval = timeBetweenTicks;
            t.Elapsed += new ElapsedEventHandler(Tick);
        }

        // Singleton pattern : allows only one instance to be created
        public static Clock Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Clock();
                    return instance;
                }
            }
        }

        // Start clock
        public void Start()
        {
            isStarted = true;
            t.Interval = timeBetweenTicks;
            t.Start();
        }

        // Stop clock
        public void Stop()
        {
            isStarted = false;
            t.Stop();
        }

        public void Tick(object sender, EventArgs e)
        {
            // Increase tickCount by 1
            tickCount++;

            // Notify all observers
            foreach (var observer in observers)
                observer.OnNext(this);
        }

        public void Warp(int multiplier)
        {
            // Modify time between ticks
            timeBetweenTicks /= multiplier;

            // Restart clock (!= Reset)
            Stop();
            Start();
        }

        // Reset clock to default values, Does NOT stop the clock.
        public void Reset()
        {
            tickCount = 0;
            timeBetweenTicks = 1000;
        }

        // Define when the restaurant is closed according to time (in ticks)
        private void openCloseRestaurant()
        {
            // TODO
        }

        // Return the actual clock tickCount
        public long GetTickCount()
        {
            return tickCount;
        }

        // Add observer to the clock
        public IDisposable Subscribe(IObserver<Clock> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber<Clock>(observers, observer);
        }
    }
}
