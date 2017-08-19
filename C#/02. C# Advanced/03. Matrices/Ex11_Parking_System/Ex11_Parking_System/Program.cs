using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Parking_System
{
    class Program
    {
        
        private static HashSet<string> occupied = new HashSet<string>();
        private static int rows;
        private static int cols;

        static void Main(string[] args)
        {
            ReadDimensions();
            ParkCars();
        }

        private static void ParkCars()
        {
            string parkingRow = Console.ReadLine();

            while (parkingRow != "stop")
            {
                int[] rowData =
                    parkingRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                int startingRow = rowData[0];
                int x = rowData[1];
                int y = rowData[2];

                string coodinates = string.Format("{0}|{1}", x, y);

                if (!occupied.Contains(coodinates))
                {
                    occupied.Add(coodinates);
                    PrintResult(true, startingRow, x, y);
                }
                else
                {
                    bool found = false;
                    int loops = Math.Max(y - 1, cols - y);
                    int col = 0;

                    for (int i = 1; i < loops; i++)
                    {
                        string left = string.Format("{0}|{1}", x, y - i);
                        string right = string.Format("{0}|{1}", x, y + i);

                        if (!occupied.Contains(left) && y - i > 0)
                        {
                            col = y - i;
                            occupied.Add(left);
                            found = true;
                            break;
                        }

                        if (!occupied.Contains(right) && y + i < cols)
                        {
                            col = y + i;
                            occupied.Add(right);
                            found = true;
                            break;
                        }
                    }

                    PrintResult(found, startingRow, x, col);
                }

                parkingRow = Console.ReadLine();
            }

        }

        private static void PrintResult(bool found, int startingRow, int row, int col)
        {
            if (found)
            {
                int distance = CalculateDistance(startingRow, row, col);
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("Row {0} full", row);
            }
        }

        private static void ReadDimensions()
        {
            int[] dimensions =
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            rows = dimensions[0];
            cols = dimensions[1];
        }

        private static int CalculateDistance(int startingRow, int row, int col)
        {
            return Math.Abs(startingRow - row) + col + 1;
        }
    }
}
