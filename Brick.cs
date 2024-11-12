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
        int[] brickID;

        // Constructor
        public Brick()
        {
            createBrick();
            ballCollisionWithBrick();
        }

        // Draw brick
        private void createBrick()
        {
            // Randomly generate a random number of blocks to display
            int blockCount = Random.Integer(96);
            brickID = new int[blockCount];

            // Randomizes the collision number
            brickNumber = Random.Integer(150);

            // Randomizes the placement of each block
            randomXPos = Random.Integer(750);
            randomYPos = Random.Integer(300); // The lowest the bricks will be rendered is at (0,350), the value is set at 300 to give room to draw the brick.

            // Brick Properties
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;
            Draw.FillColor = Color.Red;

            for (int i = 0; i < blockCount; i++)
            {
                // Draws the brick and assigns its position to an array be called on later
                Draw.Square(randomXPos, randomYPos, 50);
                // Figure out how to place the number inside the brick
            }
        }

        private void ballCollisionWithBrick(/* Get current number count on current brick and the brick ID */)
        {
            if (brickNumber <= 0)
            {
                // Destroy the brick
            } else
            {
                brickNumber--; // Remove one number from the brick collision counter
                // Redraw the brick in the same position with the new collision counter number
            }
        }
    }   
}
