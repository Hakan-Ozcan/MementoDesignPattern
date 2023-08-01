using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class TextEditorHistory
    {
        private Stack<TextEditorMemento> history = new Stack<TextEditorMemento>();
        private Stack<TextEditorMemento> redoStack = new Stack<TextEditorMemento>();
        private TextEditor editor;

        public TextEditorHistory(TextEditor editor)
        {
            this.editor = editor;
        }

        public void Save()
        {
            history.Push(editor.Save());
            redoStack.Clear();
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                var memento = history.Pop();
                redoStack.Push(editor.Save());
                editor.Restore(memento);
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var memento = redoStack.Pop();
                history.Push(editor.Save());
                editor.Restore(memento);
            }
        }
    }
}
