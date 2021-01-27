using System;
namespace GameProject
{
    interface ICampaign
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void CalculateDiscount(Campaign campaign);
    }
}
