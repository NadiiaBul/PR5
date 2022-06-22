

namespace Memento
{
    class Snapshot : IMemento
    {
        private readonly uint[][] _sudokuNum = new uint[9][];
        public Snapshot(uint[][] sudokuNum)
        {
            for (uint i = 0; i < 9; i++)
            {
                _sudokuNum[i] = new uint[9];
                for (uint j = 0; j < 9; j++)
                {
                    _sudokuNum[i][j] = sudokuNum[i][j];
                }
            }
        }
        public uint[][] GetState()
        {
            return _sudokuNum;
        }
        public void GetName()
        {
            ShowOnScreen showOnScreen = new ShowOnScreen();
            showOnScreen.PrintSudoku(_sudokuNum);
        }
    }
}
