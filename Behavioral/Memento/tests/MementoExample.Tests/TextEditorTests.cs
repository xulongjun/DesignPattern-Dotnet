using MementoExample.TextEditor;

namespace MementoExample.Tests;

public class TextEditorTests
{
    [Fact]
    public void Undo_ShouldRestorePreviousState()
    {
        var editor = new TextEditor();
        editor.Type("Hello");
        editor.Type(" World");

        Assert.Equal("Hello World", editor.Text);

        editor.Undo();
        Assert.Equal("Hello", editor.Text);
    }
}

