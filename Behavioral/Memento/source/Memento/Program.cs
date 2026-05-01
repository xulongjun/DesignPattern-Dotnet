using Memento;

var editor = new EditorOriginator();
var history = new HistoryCaretaker();

editor.SetContent("v1");
history.Push(editor.Save());

editor.SetContent("v2");
history.Push(editor.Save());

editor.SetContent("v3");

editor.Restore(history.Pop());
Console.WriteLine(editor.Content); // v2

