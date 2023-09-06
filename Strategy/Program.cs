// See https://aka.ms/new-console-template for more information

using Strategy;

Console.Title = "Strategy Pattern";

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.Export(new CSVExportService());

order.Export(new JSONExportService());

Console.ReadKey();