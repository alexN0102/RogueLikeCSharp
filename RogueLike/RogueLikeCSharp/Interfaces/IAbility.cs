﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueSharpRLNetSamples.Equipment;

namespace RogueSharpRLNetSamples.Interfaces
{
    public interface IAbility
    {
        string Name { get; }
        int TurnsToRefresh { get; }
        int TurnsUntilRefreshed { get; }

        bool Perform();
        void Tick();
    }
}
