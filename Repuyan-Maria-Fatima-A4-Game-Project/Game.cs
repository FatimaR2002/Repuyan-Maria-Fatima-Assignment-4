// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Xml.Serialization;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        public Color Background = new Color("7C9EC3");
        public Color ClawMachineColour = new Color("FFFDD0");
        public String ClawMachineName = "Sari Sari Store";
        public Color ClawMachineClear = new Color(229, 228, 226, 150);
        public Color Frame = new Color("C3B1E1");
        public Color Door = new Color(237, 234, 222, 100);
        public Color InsideDoor = new Color(237, 234, 222);
        public Color ModularBox = new Color("BDB5D5");
        Claw object1 = new Claw();
        public void Setup()
        {
            Window.SetSize(600, 800);
            Window.SetTitle("Claw Machine");
        }
        public void Update()
        {
            //Clear background to the color class Background. Make it Blue.
            Window.ClearBackground(Background);

            //Draw the body of the Claw Machine.
            //Body 9
            for (int i = 0; i < 2; i++)
            {
                int x = i * 440;
                Draw.LineSize = 0;
                Draw.FillColor = Frame;
                Draw.Circle(x + 80, 740, 10);
            }
            Draw.LineSize = 0;
            Draw.FillColor = Frame;
            Draw.Rectangle(new Vector2(80, 740), new Vector2(440, 10));
            //Body 1_Top Rectangle 
            Draw.LineSize = 1;
            Draw.FillColor = ClawMachineColour;
            Draw.Rectangle(new Vector2(20, 20), new Vector2(560, 100));
            //Body 2_Second Rectangle
            Draw.LineSize = 0;
            Draw.FillColor = Color.LightGray;
            Draw.Rectangle(new Vector2(30, 120), new Vector2(540, 20));
            //Body 3_ Third Rectangle 
            Draw.LineSize = 1;
            Draw.FillColor = ClawMachineColour;
            Draw.Rectangle(new Vector2(60, 140), new Vector2(480, 600));
            //Body 5_Frame Behind Clear Screen
            Draw.LineSize = 0f;
            Draw.FillColor = Background;
            Draw.Rectangle(new Vector2(90, 180), new Vector2(420, 240));
            //Body 10_Lines Inside Clear Screen
            Draw.LineSize = 1;
            Draw.LineColor = Color.DarkGray;
            Draw.Line(new Vector2(90, 180), new Vector2(130, 200));
            Draw.Line(new Vector2(130, 200), new Vector2(130, 370));
            Draw.Line(new Vector2(130, 370), new Vector2(90, 420));
            Draw.Line(new Vector2(130, 370), new Vector2(470, 370));
            Draw.Line(new Vector2(470, 370), new Vector2(510, 420));
            Draw.Line(new Vector2(470, 370), new Vector2(470, 200));
            Draw.Line(new Vector2(470, 200), new Vector2(510, 180));
            Draw.Line(new Vector2(470, 200), new Vector2(130, 200));
            //Body 12 Quad Inside Claw Machine
            Draw.LineSize = 0f;
            Draw.FillColor = Color.Gray;
            Draw.Quad(new Vector2(130, 370), new Vector2(470, 370), new Vector2(510, 420), new Vector2(90, 420));
            //Body 4_Clear Rectangle
            Draw.LineSize = 0f;
            Draw.FillColor = ClawMachineClear;
            Draw.Rectangle(new Vector2(90, 180), new Vector2(420, 240));
            //Body 6_Frame_Around_ClearScreen
            //Make it a For Loop
            for (int i = 0; i < 2; i++)
            {
                Draw.LineSize = 0f;
                Draw.FillColor = Frame;
                //X Coordinate. Make it go right every 440 pixels 
                int x = i * 440;
                //Draw a Rectangle that moves on the x-axis every 420 pixels 
                Draw.Rectangle(new Vector2(x + 70, 160), new Vector2(20, 280));
            }
            for (int i = 0; i < 2; i++)
            {
                Draw.LineSize = 0;
                Draw.FillColor = Frame;
                //Y Coordinate. Make it go down every
                int y = i * 260;
                //Draw a Rectangle that moves on the y-axis 
                Draw.Rectangle(new Vector2(70, y + 160), new Vector2(440, 20));
            }
            //Body 10_Quad Box
            Draw.LineSize = 0;
            Draw.FillColor = ModularBox;
            Draw.Quad(new Vector2(110, 440), new Vector2(490, 440), new Vector2(530, 520), new Vector2(70, 520));
            Draw.Rectangle(new Vector2(70, 520), new Vector2(460, 220));
            //Body 7_Door
            Draw.LineSize = 0;
            Draw.FillColor = Door;
            Draw.Rectangle(new Vector2(90, 540), new Vector2(230, 30));
            Draw.Quad(new Vector2(90, 570), new Vector2(320, 570), new Vector2(320, 700), new Vector2(120, 700));
            //Body 8_Inside_Door
            Draw.LineSize = 0;
            Draw.FillColor = InsideDoor;
            Draw.Quad(new Vector2(90, 570), new Vector2(120, 700), new Vector2(120, 720), new Vector2(90, 720));
            Draw.Rectangle(new Vector2(120, 700), new Vector2(200, 20));
            //Body 11 
            Draw.LineSize = 0;
            Draw.FillColor = InsideDoor;
            Draw.Rectangle(new Vector2(400, 540), new Vector2(110, 130));


            //OUTLINES 
            Draw.LineSize = 1f;
            Draw.LineColor = Color.DarkGray;
            Draw.PolyLine(new Vector2(110, 440), new Vector2(70, 520), new Vector2(530, 520), new Vector2(490, 440), new Vector2(110, 440));
            Draw.PolyLine(new Vector2(70, 520), new Vector2(70, 740), new Vector2(530, 740), new Vector2(530, 520));
        }
    }

}
