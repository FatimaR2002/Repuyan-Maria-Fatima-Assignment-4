using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Cassopeia
    {
        public Texture2D C1;
        public Vector2 Cposition = new Vector2(400, 400);
        public void Setup()
        {
            C1 = Graphics.LoadTexture("C:\\Users\\fatim\\source\\repos\\Repuyan-Maria-Fatima-Assignment-4\\Repuyan-Maria-Fatima-A4-Game-Project\\MohawkGame2D\\Assets/Cassiopeia");
        }
        public void Update()
        {
            Graphics.Draw(C1,Cposition);
            Graphics.Scale = 50f;
        }
    }
}
