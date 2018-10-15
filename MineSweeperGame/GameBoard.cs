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
   public class GameBoard
    {

        //Implements all the game board functionalities
        private Bombs myBombs;
        public  int[,] board { get; }
        private readonly int bombCell = 100;
        private readonly int emptyCell = 0;
        public int qtdBombs { get; }
  
        private string  playerName = "";


        //constructor
        public GameBoard(GameLevel gameLevel)
        { 
            int gameBoardRows = gameLevel.rows;
            int gameBoardColumns = gameLevel.columns;
            qtdBombs = gameLevel.qtdBombs;
            playerName = gameLevel.playerName;
            myBombs = new Bombs();
            board = myBombs.AddRandom(gameBoardRows, gameBoardColumns, qtdBombs);
   
        }

        public void CleanBoard()
        {
            //Reestart the game board state
        }

       

        //Check for adjacent bombs
        public void  AdjacentBombCounter()
        {
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= board.GetUpperBound(1); col++) 
                {
                    if (board[row,col] == 100  )
                    {

                        /*//Add adjacent bomb count on the right cell
                        if (row >= 0 && row <= board.GetUpperBound(0) && col + 1 >= 0 && col + 1 <= board.GetUpperBound(1) && board[row, col + 1] != 100) { board[row, col + 1]++; }

                        //Add adjacent bomb count on the lef cell
                        if (row >= 0 && row <= board.GetUpperBound(0) && col - 1 >= 0 && col - 1 <= board.GetUpperBound(1) && board[row, col - 1] != 100) { board[row, col - 1]++; }

                        //Add adjacent bomb count in the upper cell
                        if (row - 1 >= 0 && board[row - 1, col] != 100) { board[row - 1, col]++; }

                        // Add adjacent bomb count in the right cell bellow
                        if (row + 1 >= 0 && row + 1 <= board.GetUpperBound(1) && col + 1 >= 0 && col + 1 <= board.GetUpperBound(0) && board[row + 1, col + 1] != 100) { board[row + 1, col + 1]++; }

                        // Add adjacent bomb count in the right cell upper
                        if (row - 1 >= 0 && row - 1 <= board.GetUpperBound(1) && col + 1 >= 0 && col + 1 <= board.GetUpperBound(0) && board[row - 1, col + 1] != 100) { board[row - 1, col + 1]++; }

                        // Add adjacent bomb count in the left cell bellow
                        if (row + 1 >= 0 && row + 1 <= board.GetUpperBound(1) && col + 1 >= 0 && col + 1 <= board.GetUpperBound(0) && board[row + 1, col + 1] != 100) { board[row + 1, col + 1]++; }

                        // Add adjacent bomb count in the left cell upper
                        if (row - 1 >= 0 && row - 1 <= board.GetUpperBound(1) && col - 1 >= 0 && col - 1 <= board.GetUpperBound(0) && board[row - 1, col - 1] != 100) { board[row - 1, col - 1]++; }*/

                        //Add adjacent bomb count on the right cell
                        try
                        {
                            if (board[row, col + 1] != 100) { board[row, col + 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                           
                        }

                        try
                        {
                            //Add adjacent bomb count on the left cell
                            if (board[row, col - 1] != 100) { board[row, col - 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                           
                        }

                        try
                        {
                            //Add adjacent bomb count in the upper cell
                            if (board[row - 1, col] != 100) { board[row - 1, col]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            
                        }

                        try
                        {
                            //Add adjacent bomb count in the cell bellow
                            if (board[row + 1, col] != 100) { board[row + 1, col]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            
                        }

                        try
                        {
                            // Add adjacent bomb count in the left cell upper
                            if (board[row - 1, col - 1] != 100) { board[row - 1, col - 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            
                        }
                        try
                        {
                            // Add adjacent bomb count in the left cell down
                            if (board[row + 1, col - 1] != 100) { board[row + 1, col - 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            
                        }
                        try
                        {
                            // Add adjacent bomb count in the right cell bellow
                            if (board[row - 1, col + 1] != 100) { board[row - 1, col + 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            
                        }
                        try
                        {
                            // Add adjacent bomb count in the right cell upper
                            if (board[row + 1, col + 1] != 100) { board[row + 1, col + 1]++; }
                        }
                        catch (IndexOutOfRangeException e)
                        {
                           
                        }



                    }

                }
            }

        }

        //Check game loop and update the game board status
        public void DrawCells()
        {
            string boardLine = "";
                        
            //Drawing the array
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= board.GetUpperBound(1); col++)
                {
                    if (board[row, col] == bombCell)
                    {
                        boardLine += "[Ó]";
                    }
        
                    else if((board[row, col] != bombCell) && (board[row, col] != emptyCell))
                    {
                        boardLine += "["+board[row, col].ToString()+"]";
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
            Console.WriteLine("GRID: "+(board.GetUpperBound(0)+1)+" x "+(board.GetUpperBound(1)+1)+" NUMBER OF BOMBS: "+ qtdBombs);
            Console.WriteLine("Let's play " + playerName+"!");
            Console.WriteLine(" ");
        }
    }

    public struct GameLevel
    {
        public int rows;
        public int columns;
        public int qtdBombs;
        public string playerName;

        public GameLevel (int rows, int columns, int qtdBombs, string playerName)
        {
            this.rows = rows;
            this.columns = columns;
            this.qtdBombs = qtdBombs;
            this.playerName = playerName;
        }

    }
}
