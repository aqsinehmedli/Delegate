namespace Delegate;

public  class DocumentProgram
{
    public int Id { get; set; }
    public string Topic { get; set; }
    public DocumentProgram()
    {
    }

    public DocumentProgram(int id, string topic)
    {
        Id = id;
        Topic = topic;
    }

    public delegate void MyDelegate();

    public virtual void OpenDocument()
    {
        Console.WriteLine("Word Document Opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Word Document Edited");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Word Document Saved");
    }
}


