using System;
using System.Collections.Generic;

namespace Sandbox.Codewars.kyu4
{
    // CODEWARS: Connect 4
    public class Connect4
    {
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            string[,] frame = {
                { "empty", "empty", "empty", "empty", "empty", "empty", "empty" }, { "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                { "empty", "empty", "empty", "empty", "empty", "empty", "empty" }, { "empty", "empty", "empty", "empty", "empty", "empty", "empty" },
                { "empty", "empty", "empty", "empty", "empty", "empty", "empty" }, { "empty", "empty", "empty", "empty", "empty", "empty", "empty" }
            };

            List<string> columns = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
            List<int> columnsPlayed = new List<int>();
            int rowPlayed = 5;

            for (int i = 0; i < piecesPositionList.Count; i++)
            {
                int column = columns.IndexOf(piecesPositionList[i].Substring(0, 1));
                string colour = piecesPositionList[i].Substring(2, 1) == "R" ? "Red" : "Yellow";

                // add to column
                for (int row = 5; row >= 0; row--)
                {
                    if (frame[row, column] == "empty")
                    {
                        frame[row, column] = colour;
                        rowPlayed = Math.Min(row, rowPlayed);
                        if (!columnsPlayed.Contains(column)) { columnsPlayed.Add(column); }
                        break;
                    }
                }

                // starting from 4th play, check if we have four in sequence
                if (i >= 3)
                {
                    string result = "No Winner";

                    // check rows
                    for (int row = 5; row >= rowPlayed; row--)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            result = _checks(row, col, row, col + 1, row, col + 2, row, col + 3, frame);

                            if (result != "No Winner")
                            {
                                return result;
                            }
                        }
                    }


                    // check columns
                    foreach (int col in columnsPlayed)
                    {
                        for (int row = 5; row >= 3; row--)
                        {
                            result = _checks(row, col, row - 1, col, row - 2, col, row - 3, col, frame);

                            if (result != "No Winner")
                            {
                                return result;
                            }
                        }
                    }

                    // add check diagnal Down L to R
                    for (int col = 0; col < 4; col++)
                    {
                        for (int row = 0; row < 3; row++)
                        {
                            result = _checks(row, col, row + 1, col + 1, row + 2, col + 2, row + 3, col + 3, frame);

                            if (result != "No Winner")
                            {
                                return result;
                            }
                        }
                    }

                    // add check diagnal Up L to R
                    for (int row = 3; row < 6; row++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            result = _checks(row, col, row - 1, col + 1, row - 2, col + 2, row - 3, col + 3, frame);

                            if (result != "No Winner")
                            {
                                return result;
                            }
                        }
                    }
                }
            }
            return "Draw";
        }

        private static string _checks(int row0, int col0, int row1, int col1, int row2, int col2, int row3, int col3, string[,] frame)
        {
            if (frame[row0, col0] != "empty" && frame[row0, col0] == frame[row1, col1] && frame[row0, col0] == frame[row2, col2] && frame[row0, col0] == frame[row3, col3])
            {
                return frame[row0, col0];
            }
            else
            {
                return "No Winner";
            }
        }
    }
}
