﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return (float)(radius *radius*Math.PI);
        }
        public override float GetCircumference()
        {
            return (float)(radius*2*Math.PI);
        }
        public override void GetBounds(out float height,out float width)
        {
            height = radius * 2.0f;
            width = radius * 2.0f;
        }
    }
}
