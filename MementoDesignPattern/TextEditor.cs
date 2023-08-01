using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class TextEditor
    {
        private string text;

        public TextEditor()
        {
            text = "";
        }

        public void Write(string content)
        {
            text += content;
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(text);
        }

        public void Restore(TextEditorMemento memento)
        {
            text = memento.Text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
