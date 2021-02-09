using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    interface ICampaignService
    {
        void AddNewCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        double CalculateCampaignRate(Campaign campaign);
    }
}
