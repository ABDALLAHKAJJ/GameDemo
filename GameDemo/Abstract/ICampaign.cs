using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaign
    {
        bool AddCampaign(Campaign campaign);

        bool DeleteCampaign(Campaign campaign);

        bool UpdateCampaign(Campaign campaign, string details);
    }
}