using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MohawkGame2D
{
    public class Lives
    {
        public Color purple = new Color("CBC3E3");
        public void Setup()
        {
        }
        public void Update()
        {
            //Draw the 3 lives
            Draw.LineSize = 0f;
            Draw.FillColor = purple;
            for (int i = 0; i < 3; i++)
            {
                //Y Coordinate; make it move down every 20 px
                int y = i * 50;
                Draw.Rectangle(new Vector2(70, 300 + y), new Vector2(30, 30));
            }
        }
    }
}
