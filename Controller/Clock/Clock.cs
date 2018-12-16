﻿using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Controller.Clock
{
    class Clock : IClock, IObservable<Clock>
    {
        private static Clock instance = null;
        private static readonly object padlock = new object();

        private long tickCount;
        private int timeBetweenTicks;
        private Timer t = new Timer();

        public bool isStarted { get; set; }
        public bool isRestaurantOpen { get; set; }

        private List<IObserver<Clock>> observers;

        private Clock()
        {
            tickCount = 0;
            timeBetweenTicks = 1000;

            t.Interval = timeBetweenTicks;
            t.Elapsed += new ElapsedEventHandler(Tick);
        }

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
            tickCount++;

            foreach (var observer in observers)
                observer.OnNext(this);
        }

        public void Warp(int multiplier)
        {
            timeBetweenTicks /= multiplier;
            Stop();
            Start();
        }

        public void Reset()
        {
            tickCount = 0;
            timeBetweenTicks = 1000;
            isStarted = false;
            isRestaurantOpen = false;
        }

        private void openCloseRestaurant()
        {

        }

        public long GetTickCount()
        {
            return tickCount;
        }

        public IDisposable Subscribe(IObserver<Clock> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber<Clock>(observers, observer);
        }
    }
}
