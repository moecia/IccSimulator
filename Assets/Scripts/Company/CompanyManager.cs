using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Company
{
    public class CompanyManager : MonoBehaviour
    {
        public CompanyInfo companyInfo { get; private set; }

        public CompanyManager()
        {
            this.companyInfo = new CompanyInfo();

            // TODO: initialize company infomation from savedata and remove hardcoded settings
            companyInfo.Rank = 1;
            UpdateEmployeeLimit();
        }

        public void RankIncrement()
        {
            if (this.companyInfo.Rank < 5) 
            {
                this.companyInfo.Rank += 1;
            }
            UpdateEmployeeLimit();
        }

        public void CashIncrement(float amount)
        {
            var currCash = this.companyInfo.Cash;
            var res =  + amount;
            if (res >= float.MaxValue)
            {
                currCash = float.MaxValue;
            }
            else if (res <= float.MinValue)
            {
                currCash = float.MinValue;
            }
            else
            {
                currCash = res;
            }
        }

        public void ResearchPointsIncrement(int amount)
        {
            var currRp = this.companyInfo.ResearchPoints;
            var res = +amount;
            if (res >= float.MaxValue)
            {
                currRp = int.MaxValue;
            }
            else if (res <= float.MinValue)
            {
                currRp = int.MinValue;
            }
            else
            {
                currRp = res;
            }
        }

        private void UpdateEmployeeLimit()
        {
            switch (companyInfo.Rank)
            {
                case 1:
                    companyInfo.AccountantsLimit = 1;
                    companyInfo.AccountantManagersLimit = 0;
                    companyInfo.AttorneiesLimit = 1;
                    companyInfo.AttorniesManagerLimit = 0;
                    companyInfo.ContractorsLimit = 50;
                    companyInfo.HumanResourcesLimit = 1;
                    companyInfo.HumanResourceManagerLimit = 0;
                    companyInfo.SalesLimit = 1;
                    companyInfo.SaleManagersLimit = 0;
                    companyInfo.TrainersLimit = 1;
                    companyInfo.TrainerManagersLimit = 0;
                    break;
                case 2:
                    companyInfo.AccountantsLimit = 2;
                    companyInfo.AccountantManagersLimit = 0;
                    companyInfo.AttorneiesLimit = 2;
                    companyInfo.AttorniesManagerLimit = 0;
                    companyInfo.ContractorsLimit = 200;
                    companyInfo.HumanResourcesLimit = 4;
                    companyInfo.HumanResourceManagerLimit = 0;
                    companyInfo.SalesLimit = 2;
                    companyInfo.SaleManagersLimit = 0;
                    companyInfo.TrainersLimit = 4;
                    companyInfo.TrainerManagersLimit = 0;
                    break;
                case 3:
                    companyInfo.AccountantsLimit = 4;
                    companyInfo.AccountantManagersLimit = 0;
                    companyInfo.AttorneiesLimit = 4;
                    companyInfo.AttorniesManagerLimit = 0;
                    companyInfo.ContractorsLimit = 500;
                    companyInfo.HumanResourcesLimit = 8;
                    companyInfo.HumanResourceManagerLimit = 1;
                    companyInfo.SalesLimit = 4;
                    companyInfo.SaleManagersLimit = 1;
                    companyInfo.TrainersLimit = 8;
                    companyInfo.TrainerManagersLimit = 1;
                    break;
                case 4:
                    companyInfo.AccountantsLimit = 8;
                    companyInfo.AccountantManagersLimit = 1;
                    companyInfo.AttorneiesLimit = 8;
                    companyInfo.AttorniesManagerLimit = 1;
                    companyInfo.ContractorsLimit = 1000;
                    companyInfo.HumanResourcesLimit = 16;
                    companyInfo.HumanResourceManagerLimit = 2;
                    companyInfo.SalesLimit = 8;
                    companyInfo.SaleManagersLimit = 2;
                    companyInfo.TrainersLimit = 16;
                    companyInfo.TrainerManagersLimit = 2;
                    break;
                case 5:
                    companyInfo.AccountantsLimit = 16;
                    companyInfo.AccountantManagersLimit = 2;
                    companyInfo.AttorneiesLimit = 16;
                    companyInfo.AttorniesManagerLimit = 2;
                    companyInfo.ContractorsLimit = 1500;
                    companyInfo.HumanResourcesLimit = 3;
                    companyInfo.HumanResourceManagerLimit = 24;
                    companyInfo.SalesLimit = 12;
                    companyInfo.SaleManagersLimit = 3;
                    companyInfo.TrainersLimit = 24;
                    companyInfo.TrainerManagersLimit = 3;
                    break;
            }
        }
    }
}
