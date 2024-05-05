using APS_MAP.Produto;
namespace APS_MAP.Documento;

public class ResumeCreator : DocumentCreator
{
    public override IProduct CreateProduct()
    {
        return new Resume();
    }
}