using System;
namespace GameProject
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void SalesGame(Game game, Player player);
        void SalesGame(Game game);
    }
}
