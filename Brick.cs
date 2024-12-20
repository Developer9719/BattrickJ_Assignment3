﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Brick
    {
        // Variables
        int randomYPos;
        int randomXPos;
        int radius;
        int brickCount;

        // Constructor
        public Brick()
        {
            createBrick();
            brickCount = Random.Integer(1,80);
        }

        // Draw brick
        private void createBrick()
        {
            // Randomizes the placement of each block
            randomXPos = Random.Integer(750);
            randomYPos = Random.Integer(300); // The lowest the bricks will be rendered is at (0,350), the value is set at 300 to give room to draw the brick.
            radius = 50;

            // Brick Properties
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;
            Draw.FillColor = Color.Red;

            for (int i = 0; i < brickCount; i++)
            {
                // Draws the brick in the random position
                Draw.Square(randomXPos, randomYPos, 50);
                // Figure out how to place the number inside the brick
                

                // Calls the ballCollisionWithBrick on each generated brick 
                ballCollisionWithBrick(brickCount);
            }
        }

        private void ballCollisionWithBrick(int brickCount)
        {
            
        }

        private void endGameLogic(int brickCount)
        {
            if (brickCount <= 0)
            {
                // Freeze all motion in game


                // Display game win message
                Text.Draw("!!!WINNER WINNER!!!", 300, 300);
            }
        }
    }   
}
