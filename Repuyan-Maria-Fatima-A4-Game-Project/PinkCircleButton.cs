using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Repuyan_Maria_Fatima_A4_Game_Project
{
    public class PinkCircleButton
    {
        public Texture2D CircleP;
        public Vector2 position;
        public Vector2 radius;
        public Vector2 velocity;
        public void Setup()
        {
            //velocity = Random.Direction() * 100;

            CircleP = Graphics.LoadTexture("C:\\Users\\fatim\\source\\repos\\Repuyan-Maria-Fatima-Assignment-4\\Repuyan-Maria-Fatima-A4-Game-Project\\MohawkGame2D\\Assets/P_Circle.png");
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
            Graphics.Draw(CircleP, position);
        }
    }
}
