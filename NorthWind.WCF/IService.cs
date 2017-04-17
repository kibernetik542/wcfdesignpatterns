using System.Collections.Generic;
using System.ServiceModel;

namespace NorthWind.WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO : class
    {
        [OperationContract]
        List<DTO> Paging();

        [OperationContract]
        bool Add(DTO dto);

        [OperationContract]
        bool Update(DTO dto);

        [OperationContract]
        bool Delete(DTO dto);
    }
}
