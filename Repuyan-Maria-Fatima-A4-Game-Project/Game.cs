// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Xml.Serialization;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        public Color Background = new Color("7C9EC3");
        public void Setup()
        {
            Window.SetSize(600, 800);
            Window.SetTitle("Assignment 4");
        }
        public void Update()
        {
            Window.ClearBackground(Background);
        }
    }

}
