using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityService entityService = new PlayerManager();
            entityService.Add(new Player() { Id = 1, PlayerName = "Ayşenur", PlayerSurname = "Tunç", BirthDate = 1998, NationalityId = "12345678910" });
            entityService.Add(new Player() { Id = 2, PlayerName = "Dilara", PlayerSurname = "Ünsal", BirthDate = 1995, NationalityId = "12345678912" });


            IGameManager gameManager = new GameManager();
            gameManager.Add(new Game() { GameId = 1, GameName = "League of Legends", GamePrice = 500, GameType = "MOBA" });
            gameManager.Add(new Game() { GameId = 2, GameName = "Witcher", GamePrice = 200, GameType = "RPG" });
            gameManager.Delete(new Game() { GameName = "League of Legends" });

            gameManager.SalesGame(new Game() { GameName = "League of Legends"}, new Player() { PlayerName = "Ayşenur"});


            ICampaign campaign = new CampaignManager();
            campaign.Add(new Campaign() { Id = 1, Name = "Kara Cuma İndirimi", DiscountRate = "%50" });
            campaign.Add(new Campaign() { Id = 2, Name = "Öğrenci İndirimi", DiscountRate = "%65" });
            campaign.Delete(new Campaign() { Id = 2, Name = "Öğrenci İndirimi", DiscountRate = "%65" });
            campaign.CalculateDiscount(new Campaign() { Id = 1, Name = "Kara Cuma İndirimi", DiscountRate = "%50" });


        }
    }
}