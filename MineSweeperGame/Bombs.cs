/**
 * Program/Project: Assignment 1 Mine Sweeper Game
 * 
 * @author Marcos Silva
 * 
 * Date: 9/24/2018
 * 
 * Description: A class that set up the bombs before the game starts.  
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
    class Bombs
    {
        
        public int[,] randomBomb()
        {
            //Randomly place the bombs in the game board
            
            Random rnd = new Random();
            int randRow = 0;
            int randCol = 0;
            int row = 5;
            int col = 10;
            int bombCount = 10;
            int emptyCell = 0;
            int bombCell = 1;
            int[,] boardArray = new int[row, col];

            //0 = empty and 1= bomb
            //Populating array with 0 (empty spaces)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    boardArray[i, j] = emptyCell;
                }
            }

            //Generate random positions in the array for the bombs
            while (bombCount >0) { 
                randRow = rnd.Next(0, row);
                randCol = rnd.Next(0, col);
                if (boardArray[randRow, randCol] != bombCell)
                {
                    boardArray[randRow, randCol] = bombCell;
                    bombCount--;
                }
            }

            return boardArray;  
        }
    }
}
