using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            float s = (side1 + side2 + side3) / 2;
            return MathF.Sqrt((s-side1) * (s - side2) * (s - side3) * s);
        }
        public override float GetCircumference()
        {
            return side1+side2+side3;
        }
        public override void GetBounds(out float height, out float width)
        {
            height = (2.0f * GetSurface()) / side1;
            width = side1;
        }
    }
}