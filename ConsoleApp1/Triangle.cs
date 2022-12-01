using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    class Triangle : Surface
    {
        readonly public float side1;
        readonly public float side2;
        readonly public float side3;
        public Triangle(float side1 = 0, float side2 = 0, float side3 = 0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override float GetSurface()
        {
            float result = 0;
            float s1 = (side1 + side2 + side3) / 2.0f;

            float s2 = s1 * (s1 - side1) * (s1 - side2) * (s1 - side3);

            result = (float)Math.Sqrt(s2);
            return result;
        }
        public override float GetCircumference()
        {
            return side1+side2+side3;
        }
    }
}