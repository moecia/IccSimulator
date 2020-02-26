using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Employee
{
    public class Character : ICharacter
    {
        private readonly Employee _employee;
        private IGameManager _settingsManager;
        private EmployeeType _employeeType;

        public Character(EmployeeType employeeType)
        {
            _settingsManager = UnitOfWork.settingsManager;
            _employeeType = employeeType;

            Employee employee = BuildEmployee();
            _employee = employee;
        }

        private Employee BuildEmployee()
        {
            Employee employee = new Employee();
            switch (_employeeType)
            {
                case EmployeeType.C:
                    employee = new Contractor();
                    break;
                case EmployeeType.F:
                    employee = new Finance();
                    break;
                case EmployeeType.H:
                    employee = new HumanResources();
                    break;
                case EmployeeType.L:
                    employee = new Lawyer();
                    break;
                case EmployeeType.P:
                    employee = new PublicRelationship();
                    break;
                case EmployeeType.S:
                    employee = new Sales();
                    break;
                case EmployeeType.T:
                    employee = new Trainer();
                    break;
            }

            return employee;
        }

        public bool Hire()
        {
            throw new System.NotImplementedException();
        }

        public bool Promote()
        {
            throw new System.NotImplementedException();
        }

        public bool Dismiss()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum EmployeeType
    {
        C,
        F,
        H,
        L,
        P,
        S,
        T
    }

}
