﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interfaces
{
    public interface IActor
    {
        void threadStart();
        void action(string choice);
    }
}
