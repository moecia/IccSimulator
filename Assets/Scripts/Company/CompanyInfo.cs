using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Company
{
    public class CompanyInfo
    {
        public int Rank { get; set; }
        public float Cash { get; set; }
        public int ResearchPoints { get; set; }
        public int AvgSatisfaction { get; set; }
        public int Employees { get; set; }
        public float ResearchPointIncrementRate { get; set; }
    }
}

