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
        public float ResearchPointIncrementRate { get; set; }
        public int HumanResourcesLimit { get; set; }
        public int HumanResourceManagerLimit { get; set; }
        public int AccountantsLimit { get; set; }
        public int AccountantManagersLimit { get; set; }
        public int AttorneiesLimit { get; set; }
        public int AttorniesManagerLimit { get; set; }
        public int TrainersLimit { get; set; }
        public int TrainerManagersLimit { get; set; }
        public int SalesLimit { get; set; }
        public int SaleManagersLimit { get; set; }
        public int ContractorsLimit { get; set; }
    }
}

