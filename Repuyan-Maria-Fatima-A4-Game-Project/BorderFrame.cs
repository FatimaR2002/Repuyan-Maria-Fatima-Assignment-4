using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace MohawkGame2D
{
    public class BorderFrame
    {
        Color Border = new Color("F2C65F");

        public void Setup()
        {

        }

        public void Update()
        {
            ////Main Screen Border Frame 
            Draw.LineSize = 0f;
            Draw.FillColor = Border;
            Draw.Capsule(new Vector2(140, 140), new Vector2(660, 140), 10);
            Draw.Capsule(new Vector2(140, 470), new Vector2(660, 470), 10);
            Draw.Capsule(new Vector2(140, 470), new Vector2(140, 140), 10);
            Draw.Capsule(new Vector2(660, 470), new Vector2(660, 140), 10);

        }
    }
}
