﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IHazardNotifier
    {
        void HazardHappened(string containerNumber);
    }
}
