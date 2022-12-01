using System;
using AbstractSample;

namespace Ex32

{
    class Program
    {
        static void Main()
        {
            float height, width;

            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(5, 6, 7);
            Surface[] surfaces = {rectAngle1,rightTriangle,circle,triangle};
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out height, out width);
                Console.WriteLine($"Surfaceが入る長方形の長さは縦{height} 横{width}\n");
            }
        }
    
    }
}
