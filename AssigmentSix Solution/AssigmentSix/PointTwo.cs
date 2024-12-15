﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSix
{
    public struct PointTwo
    {
        public int x;
        public int y;
        public PointTwo(int x)
        {
            this.x = x;
            y= 0;
        }
        public PointTwo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return $"X Value is '{x}', Y Value is '{y}'.";
        }
    }
}