﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TresEnRayaCore
{
    public class Player
    {
        public char Indicator { get; set; }
        public bool IsCurrent { set; get; }
        public void AlternateTurn()
        {
            IsCurrent = !IsCurrent;
        }
    }
}
