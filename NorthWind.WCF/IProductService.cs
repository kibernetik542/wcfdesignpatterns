using NorthWind.DTO;
using System.ServiceModel;

namespace NorthWind.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService : IService<ProductDTO>
    {

    }
}
