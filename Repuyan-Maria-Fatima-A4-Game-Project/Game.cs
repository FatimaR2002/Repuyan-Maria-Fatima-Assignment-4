// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        Color MainBody = new Color("F2D48D");
        Color BG = new Color("AADCE1");
        Color Border = new Color("F2C65F");
        Color Screen = new Color("F5F4ED");
        Color Detail = new Color("F6A93A");

        //Objects
        BorderFrame object1 = new BorderFrame(); 
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Nasan Ka Na?");
        }
        public void Update()
        {
            Window.ClearBackground(BG);

            //Draw the Background for the Nintendo 3DS
            Draw.LineSize = 0f;
            Draw.FillColor = MainBody;
            Draw.Rectangle(new Vector2(60, 90), new Vector2(680, 390));
            //Bottom Corners
            Draw.LineSize = 0f;
            Draw.FillColor = MainBody;
            Draw.Rectangle(new Vector2(40, 470), new Vector2(720, 20));
            for (int i = 0; i < 2; i++)
            {
                //X Coordinate; make it move right every 720 pixels 
                int x = i * 720;
                Draw.Circle(new Vector2(40 + x, 480), 10);
            }
            //Side Corners 
            for (int i = 0; i < 2; i++)
            {
                //X Coordinate; make it move every 710
                int x = i * 710;
                Draw.Rectangle(new Vector2(30 + x, 90), new Vector2(30, 390));
            }
            ////Top Corners 
            for (int i = 0; i < 2; i++)
            {
                //x Coordinate; make it move every 680 pixels to the right
                int x = i * 680;
                Draw.Circle(new Vector2(60 + x, 100), 30);
            }

            Draw.LineSize = 0f;
            Draw.FillColor = MainBody;
            Draw.Rectangle(new Vector2(60, 70), new Vector2(680, 30));

            ////Draw the Bottom Body for the Nintendo 3DS     
            Draw.LineSize = 0f;
            Draw.FillColor = MainBody;
            Draw.Rectangle(new Vector2(40, 520), new Vector2(720, 80));

            Draw.LineSize = 0f;
            Draw.FillColor = Border;
            Draw.Capsule(new Vector2(50, 510), new Vector2(750, 510), 20);

            Draw.LineSize = 0f;
            Draw.FillColor = Screen;
            Draw.Rectangle(new Vector2(200, 550), new Vector2(390, 80));

            Draw.LineSize = 0f;
            Draw.FillColor = Border;
            Draw.Capsule(new Vector2(210, 550), new Vector2(590, 550), 10);
            Draw.Capsule(new Vector2(210, 550), new Vector2(210, 600), 10);
            Draw.Capsule(new Vector2(590, 550), new Vector2(590, 600), 10);



            /////////
            /////
            /////////

            ////Main Screen
            Draw.LineSize = 0f;
            Draw.FillColor = Screen;
            Draw.Quad(new Vector2(150, 150), new Vector2(650, 150), new Vector2(650, 460), new Vector2(150, 460));
            ////Main Screen Border Frame 
            Draw.LineSize = 0f;
            Draw.FillColor = Border;
            Draw.Capsule(new Vector2(140, 140), new Vector2(660, 140), 10);
            Draw.Capsule(new Vector2(140, 470), new Vector2(660, 470), 10);
            Draw.Capsule(new Vector2(140, 470), new Vector2(140, 140), 10);
            Draw.Capsule(new Vector2(660, 470), new Vector2(660, 140), 10);

            /////////
            /////
            /////////

            //Details();
            //Draw the indents of the 3DS
            Draw.LineSize = 0f;
            Draw.FillColor = Detail;
            for (int i = 0; i < 2; i++)
            {
                //X coordinate; make it down right every 730 pixels 
                int x = i * 730;
                Draw.Rectangle(new Vector2(30 + x, 320), new Vector2(10, 20));
                Draw.Rectangle(new Vector2(30 + x, 350), new Vector2(10, 70));
            }

            // speakers 
            Draw.LineSize = 0f;
            Draw.FillColor = Detail;
            Draw.Circle(new Vector2(80, 220), 6);
            Draw.Circle(new Vector2(80, 240), 6);
            Draw.Circle(new Vector2(100, 240), 6);
            Draw.Circle(new Vector2(80, 260), 6);
            Draw.Circle(new Vector2(60, 240), 6);
            Draw.Circle(new Vector2(710, 220), 6);
            Draw.Circle(new Vector2(690, 240), 6);
            Draw.Circle(new Vector2(710, 240), 6);
            Draw.Circle(new Vector2(730, 240), 6);
            Draw.Circle(new Vector2(710, 260), 6);

            //Hinges & Circle Details
            Draw.LineSize = 3f;
            Draw.LineColor = Detail;
            Draw.FillColor = Detail;
            Draw.Line(new Vector2(100, 490), new Vector2(100, 530));
            Draw.Line(new Vector2(700, 490), new Vector2(700, 530));
            Draw.Circle(new Vector2(740, 510), 10);
            Draw.LineSize = 0f;
            Draw.FillColor = Border;
            Draw.Circle(new Vector2(740, 510), 8);

            Draw.LineSize = 0f;
            Draw.FillColor = Detail;
            Draw.Circle(new Vector2(400, 100), 20);
            Draw.FillColor = MainBody;
            Draw.Circle(new Vector2(400, 100), 15);
            Draw.FillColor = Detail;
            Draw.Circle(new Vector2(400, 100), 10);
            Draw.Circle(new Vector2(430, 100), 10);
            Draw.FillColor = MainBody;
            Draw.Circle(new Vector2(430, 100), 6);

            Draw.FillColor = Detail;
            Draw.Circle(new Vector2(550, 100), 15);
            Draw.Circle(new Vector2(250, 100), 15);
            Draw.FillColor = MainBody;
            Draw.Circle(new Vector2(550, 100), 10);
            Draw.Circle(new Vector2(250, 100), 10);

            //Classes Update for BorderFrame
            object1.Update();
        }

    }

}
