namespace Strategy;

public class JSONExportService: IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to Json");
    }
}