using Delegate;
using System.Net;

DocumentProgram documentProgram = new DocumentProgram();

DocumentProgram.MyDelegate myDelegate = new DocumentProgram.MyDelegate(documentProgram.OpenDocument);
myDelegate += documentProgram.EditDocument;
myDelegate += documentProgram.SaveDocument;

myDelegate.Invoke();

void Display()
{
    Console.WriteLine("Key - i daxil edin:");
    string key = Console.ReadLine();
    if (key == "basic")
    {
        DocumentProgram documentProgram = new DocumentProgram(1, "Emr");

    }
    else if (key == "pro")
    {
        ProDocumentProgram proDocumentProgram = new ProDocumentProgram(2, "serencam");

    }

    else if (key == "ex")
    {
        ExpertDocument expertDocument = new ExpertDocument(3, "Teskilati sened");
    }

}