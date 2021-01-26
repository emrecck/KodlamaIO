using GameStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStore.Managers
{
    class CampaignManager
    {
        static List<ICampaign> Campaigns = null;
        public CampaignManager()
        {
            if( Campaigns == null )
            {
                Campaigns = new List<ICampaign>();
            }
        }
        public void AddCampaign(ICampaign campaign)
        {
            Campaigns.Add(campaign);
        }
        public void UpdateCampaign(ICampaign campaign)
        {
           // var element = Campaigns.FirstOrDefault(i=>i.CampaignCode == campaign.CampaignCode)
        }
        public void DeleteCampaign(ICampaign campaign)
        {
            Campaigns.Remove(campaign);
        }
    }
}
