using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu3
{
    public class BattleshipValid
    {
        // CODEWARS: Battleship field validator
        [Fact]
        public void Battleship_True()
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.True(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_ShipsByEdge_True()
        {
            int[,] field = new int[10, 10]
                     {{0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.True(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_InsufficientShips_False()
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_ExtraCrusier_False()
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_Diagonal_False()
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 0, 0, 0, 1, 0},
                      {1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_SneakyDiagonalLtoR_False()
        {
            int[,] field = new int[10, 10]
                     {{0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_SneakyDiagonalRtoL_False()
        {
            int[,] field = new int[10, 10]
                     {{0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }

        [Fact]
        public void Battleship_LongerShip_False()
        {
            int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
            Assert.False(Codewars.kyu3.BattleshipsValid.ValidateBattlefield(field));
        }
    }
}
