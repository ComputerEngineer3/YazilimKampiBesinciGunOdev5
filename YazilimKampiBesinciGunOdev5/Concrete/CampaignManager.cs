using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    class CampaignManager : ICampaignService
    {
        public void AddNewCampaign(Campaign campaign)
        {
            Console.WriteLine("New Campaign Added");
        }

        public double CalculateCampaignRate(Campaign campaign)
        {
            return campaign.DiscountRate;
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("New Campaign Deleted");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("New Campaign Updated");
        }
    }
}
