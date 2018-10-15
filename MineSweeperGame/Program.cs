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

/*
 * Classes
 * Program
 * InitGame
 * GameEventHandler / GameBoard/ DrawGameBoard
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            int rows =8;
            int cols = 8;
            int qtdBombs =10;
            string playerName = " ";

            
            Console.WriteLine("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of Bombs: ");
            qtdBombs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Name : ");
            playerName = Console.ReadLine();

            Console.WriteLine("Let's play "+playerName+"!");

            Console.Clear();

            //creating  a array to store the game board
            GameLevel myGameLevel = new GameLevel(rows, cols, qtdBombs, playerName);
            GameBoard gameBoard = new GameBoard(myGameLevel);

            //storing the random gameboard result
           // myBoard = myBombs.Add();

            //drawing header
            gameBoard.DrawHeader();
            gameBoard.AdjacentBombCounter();
            
            //drawing the gameboard
            gameBoard.DrawCells();
        }
    }
}
