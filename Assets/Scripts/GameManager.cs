using UnityEngine;
using Assets.Scripts.Company;
using Assets.Scripts.Employee;

namespace Assets.Scripts
{
    public class GameManager: MonoBehaviour
    {
        [HideInInspector]
        public static CompanyManager companyManager;
        [HideInInspector]
        public static EmployeeManager emoployeManager;
         
    }
}
