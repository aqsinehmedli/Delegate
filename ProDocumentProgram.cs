namespace Delegate;

public class ProDocumentProgram : DocumentProgram
{
    public int Id { get; set; }
    public string Topic { get; set; }
    public ProDocumentProgram(int id, string topic):base(id, topic)
    {
  
    }

    public override void EditDocument()
    {
        Console.WriteLine("Document Opened");
    }

    public sealed override void OpenDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }
}
