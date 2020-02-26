using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Company
{
    public class CompanyManager : IGameManager
    {
        public CompanyInfo companyInfo { get; private set; }

        public CompanyManager()
        {
            this.companyInfo = new CompanyInfo();
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

        public bool EmployeesUpdate(int amount)
        {
            if (this.companyInfo.Employees + amount > 0)
            {
                switch (this.companyInfo.Rank)
                {
                    case 1:
                        if (this.companyInfo.Employees + amount < Constants.RankOneMaxEmployees)
                        {
                            this.companyInfo.Employees += amount;
                            return true;
                        }
                        break;
                    case 2:
                        if (this.companyInfo.Employees + amount < Constants.RankTwoMaxEmployees)
                        {
                            this.companyInfo.Employees += amount;
                            return true;
                        }
                        break;
                    case 3:
                        if (this.companyInfo.Employees + amount < Constants.RankThreeMaxEmployees)
                        {
                            this.companyInfo.Employees += amount;
                            return true;
                        }
                        break;
                    case 4:
                        if (this.companyInfo.Employees + amount < Constants.RankFourMaxEmployees)
                        {
                            this.companyInfo.Employees += amount;
                            return true;
                        }
                        break;
                    case 5:
                        if (this.companyInfo.Employees + amount < Constants.RankFiveMaxEmployees)
                        {
                            this.companyInfo.Employees += amount;
                            return true;
                        }
                        break;
                }
            }
            return false;
        }
        
        public void Dispose()
        {
        }
    }
}
