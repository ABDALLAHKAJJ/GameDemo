using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    internal class CampaignManager : ICampaign
    {
        public bool AddCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} added with deitals: {campaign.Details}");
            return true;
        }

        public bool DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} deleted");
            return true;
        }

        public bool UpdateCampaign(Campaign campaign, string details)
        {
            Console.WriteLine($"{campaign.Id} updated with deitals: {details}");
            return true;
        }
    }
}