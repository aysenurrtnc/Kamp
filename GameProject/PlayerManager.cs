using System;
namespace GameProject
{
    class PlayerManager : IEntityService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.PlayerName + "eklendiniz!");
        }

        public void Delete(Player player)
        {
            throw new NotImplementedException(player.PlayerName + "silindi!");
        }

        public void Update(Player player)
        {
            throw new NotImplementedException(player.PlayerName + "güncellendi!");
        }
    }
}
