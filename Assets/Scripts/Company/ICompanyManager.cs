using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Company
{
    public interface ICompanyManager
    {
        void RankIncrement();
        void CashIncrement(float amount);
        void ResearchPointsIncrement(int amount);
    }
}
