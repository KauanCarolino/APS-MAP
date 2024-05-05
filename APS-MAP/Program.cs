using APS_MAP.Documento;
using APS_MAP.Produto;
namespace APS_MAP;
public class Program
{
    public static void Main(String[] args)
    {
        DocumentCreator reportCreator = new ReportCreator();
        DocumentCreator resumeCreator = new ResumeCreator();

        IProduct report = reportCreator.CreateProduct();
        report.Generate();

        IProduct resume = resumeCreator.CreateProduct();
        resume.Generate();
    }
}