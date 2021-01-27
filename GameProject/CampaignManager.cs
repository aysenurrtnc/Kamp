using System;
namespace GameProject
{
    class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyası eklendi..");
        }

        public void CalculateDiscount(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountRate + "kampanyalı fiyatı hesaplandı..");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyası kaldırıldı..");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyası güncellendi..");
        }
    }
}
