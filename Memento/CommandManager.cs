namespace Memento;

public class CommandManager
{
    private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new();
    private AddEmployeeToManagerList? _command;
    public void Invoke(ICommand command)
    {
        _command ??= (AddEmployeeToManagerList) command;
        
        if (!command.CanExecute()) return;
        
        command.Execute();
        _mementos.Push(((AddEmployeeToManagerList) command).CreateMemento());
    }

    public void Undo()
    {
        if (!_mementos.Any()) return;
        
        _command?.RestoreMomento(_mementos.Pop());
        _command?.Undo();
    }

    public void UndoAll()
    {
        while (_mementos.Any())
        {
            Undo();
        }
    }
}