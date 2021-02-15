using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaign
    {
        bool AddCampaign(string name, string details);

        bool DeleteCampaign(int campaignId);

        bool UpdateCampaign(int id, string details);
    }
}