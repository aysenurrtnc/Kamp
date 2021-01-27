using System;
namespace GameProject
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu eklendi..");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu silindi..");
        }

        public void SalesGame(Game game, Player player)
        {
            Console.WriteLine(player.PlayerName + "," + game.GameName + "oyununu satın aldı..");
        }

        public void SalesGame(Game game)
        {
            Console.WriteLine(game.GameName + "oyununu satın aldınız..");
        }
    }
}
