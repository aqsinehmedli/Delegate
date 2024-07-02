namespace Delegate;

public class ExpertDocument : ProDocumentProgram
{
    public int Id1 { get; set; }
    public string Topic1 { get; set; }
    public ExpertDocument(int id, string topic) : base(id, topic)
    {

    }

    

    public void OpenDocument()
    {
        Console.WriteLine("Open Document");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Document Saved in pdf format");
    }
}