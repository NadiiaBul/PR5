using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    class Caretaker
    {
        private readonly List<IMemento> _backUp = new List<IMemento>();
        private readonly Sudoku _sudoku;
        public Caretaker(Sudoku sudoku)
        {
            _sudoku = sudoku;
        }
        public void MakeBackUp()
        {
            _backUp.Add(_sudoku.CreateSnapshot());
        }
        public void Undo()
        {
            if(_backUp.Count != 0)
            {
                _sudoku.Restore(_backUp.Last());
                _backUp.Remove(_backUp.Last());
            }
        }
        public void ShowHistory()
        {
            ShowOnScreen showOnScreen = new ShowOnScreen();
            if (_backUp.Count == 0)
            {
                showOnScreen.PrintCondition("History is empty.");
                return;
            }
            showOnScreen.PrintCondition("History:\n");
            foreach(var x in _backUp)
            {
                x.GetName();
            }
        }
    }
}
