using APS_MAP.Produto;
namespace APS_MAP.Documento;

public class ReportCreator : DocumentCreator
{
    public override IProduct CreateProduct()
    {
        return new Report();
    }
}