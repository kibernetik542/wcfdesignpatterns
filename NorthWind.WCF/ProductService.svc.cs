﻿using NorthWind.DTO;
using NorthWind.Entity.Model;
using NorthWind.Repository;

namespace NorthWind.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : ServiceBase<ProductRepository, Urunler, ProductDTO>
    {

    }
}
