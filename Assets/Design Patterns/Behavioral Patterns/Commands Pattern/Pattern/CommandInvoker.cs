using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
    public class CommandInvoker : MonoBehaviour
    {
        private static Stack<ICommand> _undoStack = new Stack<ICommand>();
        private static Stack<ICommand> _redoStack = new Stack<ICommand>();

        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);

            _redoStack.Clear();
        }

        public static void UndoCommand()
        {
            if (_undoStack.Count > 0)
            {
                ICommand activeCommand = _undoStack.Pop();
                _redoStack.Push(activeCommand);
                activeCommand.Undo();
            }
        }

        public static void RedoCommand()
        {
            if (_redoStack.Count > 0)
            {
                ICommand activeCommand = _redoStack.Pop();
                _undoStack.Push(activeCommand);
                activeCommand.Execute();
            }
        }
    }
}
