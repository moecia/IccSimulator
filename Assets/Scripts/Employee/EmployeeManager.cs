using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Employee
{
    public class EmployeeManager : MonoBehaviour, IEmoployeManager
    {
        private Employee employees = new Employee();

        public EmployeeManager()
        {

        }

        public void UpdateEmployees(string employeeType, int increment)
        {
            var info = GameManager.companyManager.companyInfo;
            switch (employeeType)
            {
                case "HR":
                    if (employees.HumanResources + increment >= 0
                        || employees.HumanResources + increment <= info.HumanResourcesLimit)
                    {
                        employees.HumanResources += increment;
                    }
                    break;
                case "HRM":
                    if (employees.HumanResources + increment >= 0
                        || employees.HumanResourcesManagers + increment <= info.HumanResourceManagerLimit)
                    {
                        employees.HumanResourcesManagers += increment;
                    }
                    break;
                case "AC":
                    if (employees.Accountants + increment >= 0
                        || employees.Accountants + increment <= info.AccountantsLimit)
                    {
                        employees.Accountants += increment;
                    }
                    break;
                case "ACM":
                    if (employees.AccountantsManagers + increment >= 0
                        || employees.AccountantsManagers + increment <= info.AccountantManagersLimit)
                    {
                        employees.AccountantsManagers += increment;
                    }
                    break;
                case "AT":
                    if (employees.Attorneies + increment >= 0
                        || employees.Attorneies + increment <= info.AttorneiesLimit)
                    {
                        employees.Attorneies += increment;
                    }
                    break;
                case "ATM":
                    if (employees.AttorneyManagers + increment >= 0
                        || employees.AttorneyManagers + increment <= info.AttorniesManagerLimit)
                    {
                        employees.AttorneyManagers += increment;
                    }
                    break;
                case "CO":
                    if (employees.Conrtractors + increment >= 0
                        || employees.Conrtractors + increment <= info.ContractorsLimit)
                    {
                        employees.Conrtractors += increment;
                    }
                    break;
                case "SA":
                    if (employees.Sales + increment >= 0
                        || employees.Sales + increment <= info.SalesLimit)
                    {
                        employees.Sales += increment;
                    }
                    break;
                case "SAM":
                    if (employees.SaleManagers + increment >= 0
                        || employees.SaleManagers + increment <= info.SaleManagersLimit)
                    {
                        employees.SaleManagers += increment;
                    }
                    break;
                case "TR":
                    if (employees.Trainers + increment >= 0
                        || employees.Trainers + increment <= info.TrainersLimit)
                    {
                        employees.Trainers += increment;
                    }
                    break;
                case "TRM":
                    if (employees.TrainerManagers + increment >= 0
                        || employees.TrainerManagers + increment <= info.TrainerManagersLimit)
                    {
                        employees.TrainerManagers += increment;
                    }
                    break;
            }
        }
    }
}
