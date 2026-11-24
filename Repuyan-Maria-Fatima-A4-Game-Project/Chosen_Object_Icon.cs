using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Chosen_Object_Icon
    {
        public Color Border = new Color("F2C65F");

        public void Setup()
        {
        }
        public void Update()
        {
            Draw.LineSize = 1f;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.OffWhite;
            Draw.Rectangle(new Vector2(660, 40), new Vector2(110, 100));
        }
    }
}
