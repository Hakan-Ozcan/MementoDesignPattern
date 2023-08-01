using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class TextEditorMemento
    {
        public string Text { get; private set; }

        public TextEditorMemento(string text)
        {
            Text = text;
        }
    }
}
