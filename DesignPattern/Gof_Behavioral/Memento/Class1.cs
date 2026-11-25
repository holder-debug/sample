namespace DesignPattern.Gof_Behavioral.Memento;

public class TextMemento
{
    public string Text { get; }

    public TextMemento(string text)
    {
        Text = text;
    }
}


public class TextEditor
{
    public string Text { get; set; } = "";

    public TextMemento Save()
    {
        return new TextMemento(Text);
    }

    public void Restore(TextMemento memento)
    {
        Text = memento.Text;
    }
}

public class History
{
    private readonly Stack<TextMemento> _history = new();

    public void Save(TextMemento memento)
    {
        _history.Push(memento);
    }

    public TextMemento Undo()
    {
        return _history.Pop();
    }
}


public class MementoCaller
{
    public void Call()
    {
        var editor = new TextEditor();
        var history = new History();

        editor.Text = "Hello";
        history.Save(editor.Save());

        editor.Text = "Hello World";
        history.Save(editor.Save());

        editor.Text = "Hello World!";

        // Undo
        editor.Restore(history.Undo());

        Console.WriteLine(editor.Text);
    }
}