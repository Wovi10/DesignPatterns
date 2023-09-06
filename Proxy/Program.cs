// See https://aka.ms/new-console-template for more information

using Proxy;

Console.Title = "Proxy pattern";

// DocumentConstruction();
//
// Console.WriteLine();
//
// ProxyDocumentConstruction();
//
// Console.WriteLine();

ProtectedProxyDocumentConstruction();

Console.ReadKey();
return;

void DocumentConstruction()
{
    Console.WriteLine("Constructing document.");
    var myDocument = new Document("MyDocument.pdf");
    Console.WriteLine("Document constructed.");
    myDocument.DisplayDocument();
}

void ProxyDocumentConstruction()
{
    Console.WriteLine("Constructing document proxy.");
    var myDocumentProxy = new DocumentProxy("MyDocument.pdf");
    Console.WriteLine("Document proxy constructed");
    myDocumentProxy.DisplayDocument();
}

void ProtectedProxyDocumentConstruction()
{
    Console.WriteLine("Constructing protected document proxy.");
    var myProtrectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
    Console.WriteLine("Protected document proxy constructed.");
    myProtrectedDocumentProxy.DisplayDocument();

    Console.WriteLine();

    Console.WriteLine("Constructing protected document proxy");
    myProtrectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "Another role");
    Console.WriteLine("Protected document proxy constructed.");
    myProtrectedDocumentProxy.DisplayDocument();
}