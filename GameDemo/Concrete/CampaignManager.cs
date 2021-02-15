using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    internal class CampaignManager : ICampaign
    {
        public bool AddCampaign(string name, string details)
        {
            Console.WriteLine($"{name} added with deitals: {details}");
            return true;
        }

        public bool DeleteCampaign(int campaignId)
        {
            Console.WriteLine($"{campaignId} deleted");
            return true;
        }

        public bool UpdateCampaign(int id, string details)
        {
            Console.WriteLine($"{id} updated with deitals: {details}");
            return true;
        }
    }
}