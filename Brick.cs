using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Brick
    {
        // Variables
        int brickNumber;
        int randomYPos;
        int randomXPos;

        // Constructor
        public Brick()
        {
            createBrick();
        }

        // Draw brick
        private void createBrick()
        {
            // Randomizes the collision number
            brickNumber = Random.Integer(150);

            // Randomizes the placement of each block
            randomXPos = Random.Integer(750);
            randomYPos = Random.Integer(300); // The lowest the bricks will be rendered is at (0,350), the value is set at 300 to give room to draw the brick.
            
            // Brick Properties
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;
            Draw.FillColor = Color.Red;

            // Draws the brick
            Draw.Square(randomXPos, randomYPos, 50);
        }
    }   
}
