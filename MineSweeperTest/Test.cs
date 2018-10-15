using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MineSweeperGame;

namespace MineSweeperTest
{
    public class Test
    {
        [Fact]
        public void AddRandom_ShouldReturnRightNumBoms()
        {
            //Arrange
            int numberOfBombs = 10;
            int gridRows = 8;
            int gridColumns = 8;
            int[,] finalBombArray;
            Bombs myBombs = new Bombs();
            int expected = 10;
            int response = 0;

            //Act
            finalBombArray = myBombs.AddRandom(gridRows, gridColumns, numberOfBombs);

            foreach (int position in finalBombArray)
            {
                if (position == 100)
                {
                    response++;
                }
            }

            //Assert
            Assert.Equal(expected, response);
        }

        [Fact]
        public void GameBoardShouldReturnTheRightAmountofRows()
        {
            //Arrange
            int numberOfBombs = 4;
            int gridRows = 10;
            int gridColumns = 6;
            string playerName = "Tester";

            GameLevel myGameLevel = new GameLevel(gridRows, gridColumns, numberOfBombs, playerName);
            GameBoard gameBoard = new GameBoard(myGameLevel);
            int expected = 10;
            int response = 0;

            //Act
            response = gameBoard.board.GetUpperBound(0)+1;

            //Assert
            Assert.Equal(expected, response);
        }

        [Fact]
        public void GameBoardShouldReturnTheRightAmountofColumns()
        {
            //Arrange
            int numberOfBombs = 4;
            int gridRows = 10;
            int gridColumns = 6;
            string playerName = "Tester";

            GameLevel myGameLevel = new GameLevel(gridRows, gridColumns, numberOfBombs, playerName);
            GameBoard gameBoard = new GameBoard(myGameLevel);
            int expected = 6;
            int response = 0;

            //Act
            response = gameBoard.board.GetUpperBound(1) + 1;

            //Assert
            Assert.Equal(expected, response);
        }
    }
}
