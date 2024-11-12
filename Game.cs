// Include code libraries you need below (use the namespace).
using Game10003;
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Ball vs Brick");
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            
            // Draw Game Borders: Not doing anything yet
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;
            Draw.Line(0, 600, 800, 600);
            Draw.Line(0, 0, 0, 600);
            Draw.Line(0, 0, 800, 0);
            Draw.Line(800, 0, 800, 600);
            
            // Create players ball
            Ball playerBall = new Ball();

            // Create the game bricks
            Brick gameBricks = new Brick();
        }
    }
}
