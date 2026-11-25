using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Orange_Sun
    {
        public Color Border = new Color("F2C65F");
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 radius;
        public Texture2D SunO;

        public void Setup()
        {
            velocity = Random.Direction() * 100;

            Graphics.LoadTexture("C:\\Users\\fatim\\source\\repos\\Repuyan-Maria-Fatima-Assignment-4\\Repuyan-Maria-Fatima-A4-Game-Project\\MohawkGame2D\\Assets/O_Sun.png");
        }
        public void Update()
        {
            position += velocity * Time.DeltaTime;

            //Functions
            Render();
        }
        public void Render()
        {
            Graphics.Scale = 10f;
            Graphics.Draw(SunO, position);
        }

    }
}
