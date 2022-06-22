using System;

namespace Memento
{
    class Sudoku
    {
        public uint[][] Numbers { get; set; } = new uint[][] 
        {
          new uint[] { 0, 0, 0, 0, 5, 0, 0, 8, 0 },
          new uint[] { 4, 0, 5, 0, 8, 6, 0, 0, 2 },
          new uint[] { 0, 0, 8, 0, 9, 0, 0, 0, 5 },
          new uint[] { 0, 0, 2, 5, 7, 0, 0, 0, 3 },
          new uint[] { 0, 8, 0, 0, 0, 0, 0, 7, 0 },
          new uint[] { 6, 0, 0, 0, 3, 4, 1, 0, 0 },
          new uint[] { 7, 0, 0, 0, 1, 0, 4, 0, 0 },
          new uint[] { 5, 0, 0, 2, 6, 0, 9, 0, 7 },
          new uint[] { 0, 3, 0, 0, 4, 0, 0, 0, 0 }
        };
        public void AddNumber(uint firstPos, uint secondPos, uint number)
        {
            try 
            { 
                if(number < 1 || number > 9)
                {
                    throw new ArgumentException("This number is not allowed in sudoku");
                }
                if (Numbers[firstPos][secondPos] == 0)
                {
                    Numbers[firstPos][secondPos] = number;
                }
                else
                {
                    Console.WriteLine("This cell is occupied.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Restore(IMemento memento)
        {
            uint[][] sudokuNum = memento.GetState();
            for (uint i = 0; i < 9; i++)
            {
                for (uint j = 0; j < 9; j++)
                {
                    Numbers[i][j] = sudokuNum[i][j];
                }
            }
        }
        public IMemento CreateSnapshot()
        {
            return new Snapshot(Numbers);
        }
    }
}
