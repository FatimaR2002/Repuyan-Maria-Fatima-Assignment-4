using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Text;

using MohawkGame2D;
using System.Drawing;

namespace MohawkGame2D
{
    public class PlaceHolder
    {
        public Color Pink = new Color("F8C8DC");
        public Vector2 position;
        public float radius;
        public Vector2 velocity;
        public void Setup()
        {
        }

        public void Update()
        {
            Draw.LineSize = 0f;
            Draw.FillColor = Pink;
            Draw.Circle(new Vector2(400, 400), 30);

        }
    }
}
