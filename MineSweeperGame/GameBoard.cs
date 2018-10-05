/**
 * Program/Project: Assignment 1 Mine Sweeper Game
 * 
 * @author Marcos Silva
 * 
 * Date: 9/24/2018
 * 
 * Description: A class that implements Mines Sweeper game board.  
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
    class GameBoard
    {

        //Implements all the game board functionalities
        //bool reviealCell = false;
        //bool clickedCell = false;
        //int flagCounting = 10;
        //int timer;
        //CreateGrid();
        //StartTimer();

        //constructor
        public GameBoard(){

        }

        public void cleanBoard()
        {
            //Reestart the game board state
        }

        //Check game loop and update the game board status
        public void DrawCells(int[,] board)
        {
            string boardLine = "";

            //Drawing the array
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if (board[i, j] == 1)
                    {
                        boardLine += "[Ó]";
                    }
                    else
                    {
                        boardLine += "[ ]";
                    }
                }


                Console.WriteLine(boardLine);
                boardLine = "";
            }

            Console.ReadKey();
        }

        public void DrawHeader()
        {
            //Drawing the header
            Console.WriteLine("*------------------------------*");
            Console.WriteLine("|       MINESWEEPER GAME       |");
            Console.WriteLine("|       BY MARCOS SILVA        |");
            Console.WriteLine("*------------------------------*");
            Console.WriteLine("");
            Console.WriteLine("  [010]       :)       [000]   ");
            Console.WriteLine("");
        }
    }
}
