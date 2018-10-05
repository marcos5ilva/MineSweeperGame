/**
 * Program/Project: Assignment 1 Mine Sweeper Game
 * 
 * @author Marcos Silva
 * 
 * Date: 9/24/2018
 * 
 * Description: Runs the Mine Sweeper Game.  
 *  
 * Instructor: Barbara Chamberlin  Section: 1
 *
 * Fall Term 2018
 */

/*Gameplay: 
The player is presented to a game board with an 8x8 matrix of squares.Behind each square, the player can find either an empty space, a hint(number), or a bomb (end of the game).
 The Player starts randomly choosing a square, by click on it.That square can review a hint, a number that shows how many bobs you have adjacent to the box you've just clicked, an empty space or a bomb.

What will be challenging to program?
-The visual aspect of it.
-The adjacent number of bombs method.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating  a array to store the game board
            int[,] myBoard = new int[5, 10];

            
            InitGame myInitGame = new InitGame();
            DrawGameBoard drawGame = new DrawGameBoard();

            //storing the random gameboard result
            myBoard = myInitGame.randomBomb();

            //drawing header
            drawGame.DrawHeader();
            //drawing the gameboard
            drawGame.DrawCells(myBoard);
        }
    }
}
