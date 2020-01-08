using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Company
{
    public class CompanyManager : MonoBehaviour, IGameManager
    {
        private static CompanyManager instance;
        public static CompanyManager Instance
        {
            get 
            {
                if (!instance)
                {
                    instance = new CompanyManager();
                }
                return instance;
            }
        }

        public CompanyInfo companyInfo { get; private set; }

        public CompanyManager()
        {
            // TODO: Read save file
            companyInfo = new CompanyInfo();
        }

        public void RankIncrement()
        {
            if (this.companyInfo.Rank < 5) 
            {
                this.companyInfo.Rank += 1;
            }
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

        public void Dispose()
        {
        }

        public void StartUp()
        {
            instance = new CompanyManager(); 
        }
    }
}
