using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractSample
{
    abstract class Surface
    {
        abstract public float GetSurface(); //面積を取得する
        abstract public float GetCircumference(); //周囲の長さを取得する
        abstract public void GetBounds(out float height,out float width);
    }
}
