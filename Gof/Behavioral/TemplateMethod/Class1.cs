namespace Gof.Behavioral.TemplateMethod;

public abstract class ReportGenerator
{
    public void Generate()
    {
        GetData();

        ProcessData();

        Export();

        Send();
    }

    protected abstract void GetData();

    protected abstract void ProcessData();

    protected abstract void Export();

    protected virtual void Send()
    {
        Console.WriteLine("Sending report...");
    }
}



public class PdfReportGenerator : ReportGenerator
{
    protected override void GetData()
    {
        Console.WriteLine("Getting PDF data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing PDF data...");
    }

    protected override void Export()
    {
        Console.WriteLine("Exporting PDF...");
    }
}



public class ExcelReportGenerator : ReportGenerator
{
    protected override void GetData()
    {
        Console.WriteLine("Getting Excel data...");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Processing Excel data...");
    }

    protected override void Export()
    {
        Console.WriteLine("Exporting Excel...");
    }
}




//ReportGenerator report = new PdfReportGenerator();

//report.Generate();

//Console.WriteLine("--------------");

//report = new ExcelReportGenerator();

//report.Generate();