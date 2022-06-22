using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku sudoku = new Sudoku();
            Caretaker caretaker = new Caretaker(sudoku);

            ShowOnScreen showOnScreen = new ShowOnScreen();
            showOnScreen.PrintCondition("Before changes:\n");
            showOnScreen.PrintSudoku(sudoku.Numbers);

            caretaker.MakeBackUp();
            sudoku.AddNumber(0, 0, 7);

            showOnScreen.PrintCondition("After BackUp and changed:\n");
            showOnScreen.PrintSudoku(sudoku.Numbers);

            caretaker.ShowHistory();

            caretaker.Undo();
            showOnScreen.PrintCondition("After restore:\n");
            showOnScreen.PrintSudoku(sudoku.Numbers);
            caretaker.ShowHistory();

            Console.ReadKey();
        }
    }
}
