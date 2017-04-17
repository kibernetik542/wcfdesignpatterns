using NorthWind.Extensions;
using NorthWind.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthWind.WCF
{
    public class ServiceBase<Rep, Entity, DTO> : IService<DTO>
        where DTO : class
        where Rep : RepositoryBase<Entity>
        where Entity : class
    {


        public Rep repository;



        public Rep Repository
        {
            get
            {
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }
            set { repository = value; }
        }


        public bool Add(DTO dto) => Repository.Add(dto.Changer<Entity>());

        public bool Delete(DTO dto) => Repository.Delete(dto.Changer<Entity>());

        public List<DTO> Paging() => Repository.Paging().Select(x => x.Changer<DTO>()).ToList();

        public bool Update(DTO dto) => Repository.Update(dto.Changer<Entity>());
    }
}