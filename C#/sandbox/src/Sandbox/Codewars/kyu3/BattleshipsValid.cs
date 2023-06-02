using System;

namespace Sandbox.Codewars.kyu3
{
    // CODEWARS: Battleship field validator
    public class BattleshipsValid
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            // Config
            int[] shipExpected = { 4, 3, 2, 1, 0 }; // submarine len: 1 exp: 4, destroyer len: 2 exp: 3, crusier len: 3 exp: 2, battleship len: 4 exp: 1, exceptions len: >4 exp: 0
            int[] shipFound = { 0, 0, 0, 0, 0 }; // submarine, destroyer, crusier, battleship, exceptions
            int len = 0;
            string direction = "across";

            // Find and record Ships Across
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Tuple<int[], int> temp = _shipFinder(shipFound, field, direction, len, y, x, x, x, y, y + 1, y - 1); // across x are all equal. y1 and y2 varies +1 or -1
                    shipFound = temp.Item1;
                    len = temp.Item2;
                }

                if (len > 0)
                {
                    shipFound = _shipCheck(len, shipFound, direction);
                    len = 0;
                }
            }

            // Find and record Ships Down
            direction = "down";
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Tuple<int[], int> temp = _shipFinder(shipFound, field, direction, len, x, x, x + 1, x - 1, y, y, y); // across y are all equal. x1 and x2 varies +1 or -1
                    shipFound = temp.Item1;
                    len = temp.Item2;
                }

                if (len > 0)
                {
                    shipFound = _shipCheck(len, shipFound, direction);
                    len = 0;
                }
            }

            // if too many of a type or not enough, false
            for (int i = 0; i < 4; i++)
            {
                if (shipExpected[i] != shipFound[i])
                {
                    return false;
                }
            }

            // Check if any diagonal, if so false
            // diagonal L to R
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (!_diagonalsCheck(field, x, y, x + 1, y + 1))
                    {
                        return false;
                    }
                }
            }

            // diagonal R to L
            for (int y = 0; y < 9; y++)
            {
                for (int x = 9; x > 0; x--)
                {
                    if (!_diagonalsCheck(field, x, y, x - 1, y + 1))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static Tuple<int[], int> _shipFinder(int[] shipFound, int[,] field, string direction, int len, int xOrY, int x, int x1, int x2, int y, int y1, int y2) // Tuple allows multiple fields back
        {
            if (xOrY == 0 && field[y, x] == 1 && field[y1, x1] == 0) // check if current cordinates have a ship
            {
                len++;
            }
            else if (xOrY > 0 && xOrY < 9 && field[y, x] == 1 && field[y1, x1] == 0 && field[y2, x2] == 0)
            {
                len++;
            }
            else if (xOrY == 9 && field[y, x] == 1 && field[y2, x2] == 0)
            {
                len++;
            }
            else if (len > 0 && field[y, x] == 0) // end of ship
            {
                shipFound = _shipCheck(len, shipFound, direction);
                len = 0;
            }

            return Tuple.Create(shipFound, len);
        }

        private static int[] _shipCheck(int len, int[] shipFound, string direction)
        {
            int min = direction == "across" ? 0 : 1;

            if (len < 5 && len > min) // min determines whether to exclude submarines
            {
                shipFound[len - 1]++;
            }
            else if (len > 5)
            {
                shipFound[4]++;
            }

            return shipFound;
        }

        private static bool _diagonalsCheck(int[,] field, int x0, int y0, int x1, int y1)
        {
            return field[x0, y0] == 1 && field[x1, y1] == 1 ? false : true;
        }
    }
}
