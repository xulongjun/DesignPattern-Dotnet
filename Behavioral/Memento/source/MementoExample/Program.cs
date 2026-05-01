using MementoExample.TextEditor;

var editor = new TextEditor();
editor.Type("Hello");
editor.Type(" World");
Console.WriteLine(editor.Text);

editor.Undo();
Console.WriteLine(editor.Text);

