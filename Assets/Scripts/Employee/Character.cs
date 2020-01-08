using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Employee
{
    public class Character : MonoBehaviour, ICharacter
    {
        private readonly Employee employee;

        public Character(EmployeeType type)
        {
            switch (type) 
            {
                case EmployeeType.Contractor:
                    employee = new Contractor();
                    break;
                case EmployeeType.Finance:
                    employee = new Finance();
                    break;
                case EmployeeType.Hr:
                    employee = new HumanResources();
                    break;
                case EmployeeType.Lawyer:
                    employee = new Lawyer();
                    break;
                case EmployeeType.Pr:
                    employee = new PublicRelationship();
                    break;
                case EmployeeType.Sales:
                    employee = new Sales();
                    break;
                case EmployeeType.Traing:
                    employee = new Contractor();
                    break;
            }
        }

        public void Report()
        {
            Debug.Log(this.GetType() + " report to duty");
        }
    }

    public enum EmployeeType
    {
        Contractor,
        Finance,
        Hr,
        Lawyer,
        Pr,
        Sales,
        Traing
    }
}
