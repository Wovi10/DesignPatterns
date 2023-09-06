namespace Proxy;

public class Document: IDocument
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public int AuthorId { get; set; }
    public DateTimeOffset LastAccessed { get; set; }
    private string _fileName;

    public Document(string fileName)
    {
        _fileName = fileName;
        LoadDocument(fileName);
    }

    private void LoadDocument(string fileName)
    {
        Console.WriteLine("Executing expensive action: loading a file form disk");
        Thread.Sleep(1000);

        Title = "An expensive document";
        Content = "Lots and lots of content";
        AuthorId = 1;
        LastAccessed = DateTimeOffset.UtcNow;
    }

    public void DisplayDocument()
    {
        Console.WriteLine($"Title: {Title}, Content: {Content}");
    }
}