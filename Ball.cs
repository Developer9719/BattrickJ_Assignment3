using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Raylib_cs;


namespace Game10003
{
    public class Ball
    {
        // Variables
        string collisionType; // What did the ball collide with. Used to pass to collisionResolution

        // Constructor
        public Ball()
        {
            createBall();
            collisionDetection();
            collisionResolution();
        }

        private void createBall() 
        {
            // Ball Properties
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Blue;

            // Draw Ball
            Draw.Circle(400, 575,25);
        }

        private void userInteraction()
        {
            // Check if the ball is at the bottom of the screen
            if ()
            {
                // If ball is at the bottom of the screen stop its motion

                // Using the mouse position draw a dotted line between the ball and the cursor location to show the path of the ball
            } 
            
            // When the user clicks on the left mouse button release the ball following the path
        }

        private void collisionDetection()
        {

        }

        private void collisionResolution()
        {

        }
    }
}
