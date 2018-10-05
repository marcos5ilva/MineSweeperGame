/**
 * Program/Project: Assignment 1 Mine Sweeper Game
 * 
 * @author Marcos Silva
 * 
 * Date: 9/24/2018
 * 
 * Description: A class that set up the game before the player starts to play.  
 *  
 * Instructor: Barbara Chamberlin  Section: 1
 *
 * Fall Term 2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGame
{
    class InitGame
    {
        public void cleanBoard()
        {
            //Reestart the game board state
        }
        public int[,] randomBomb()
        {
            //Randomly place the bombs in the game board
            int[,] boardArray = new int[5, 10];
            Random rnd = new Random();
            int row = 0;
            int col = 0;
            int bombCount = 10;

            //0 = empty and 1= bomb
            //Populating array with 0 (empty spaces)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    boardArray[i, j] = 0;
                }
            }

            //Genarate random positions in the array for the bombs
            while (bombCount >0) { 
                row = rnd.Next(0, 5);
                col = rnd.Next(0, 10);
                if (boardArray[row, col] != 1)
                {
                    boardArray[row, col] = 1;
                    bombCount--;
                }
            }

            return boardArray;  
        }
    }
}
