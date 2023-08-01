using MementoDesignPattern;

public class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        TextEditorHistory history = new TextEditorHistory(editor);

        editor.Write("Hello, ");
        history.Save();
        Console.WriteLine(editor); // Output: Hello,

        editor.Write("Memento Pattern!");
        history.Save();
        Console.WriteLine(editor); // Output: Hello, Memento Pattern!

        history.Undo();
        Console.WriteLine(editor); // Output: Hello,

        history.Redo();
        Console.WriteLine(editor); // Output: Hello, Memento Pattern!
    }
}