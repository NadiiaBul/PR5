using System;

namespace Memento
{
    class ShowOnScreen
    {
        public void PrintSudoku(uint[][] numbers)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PrintCondition(string text)
        {
            Console.WriteLine(text);
        }
    }
}
