using System;
namespace GameProject
{
    interface IEntityService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
