using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Contract
{
    public class Contract
    {
        public int MinimumStipend { get; set; }
        public int ContractLength { get; set; }
        public int PenaltyMultiplier { get; set; }
        public bool Sponsorship { get; set; }
        public bool TrainingWithoutEad { get; set; }
        public bool FulltimeOnClient { get; set; }
        public bool ProvideMedicalIns { get; set; }
        public MedicalInsurance MedicalIns { get; set; }
        public bool ProvideRetireWealthPlan { get; set; }
        public RetireWealthPlan RetireWealthPlan { get; set; }
        public bool ProvideHousing { get; set; }
        public Housing HousingPlan { get; set; }
        public int EarlyLeavePenalty { get; set; }
        public int PtoDays { get; set; }
        public int MarketingMonthsRange { get; set; }
        public float SalaryLowerLimit { get; set; }
    }
}
