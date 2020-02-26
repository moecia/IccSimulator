using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Company;
using Assets.Scripts.Employee;
using Assets.Scripts.Settings;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class UnitOfWork: MonoBehaviour
    {
        [HideInInspector]
        public static IGameManager companyManager;
        [HideInInspector]
        public static IGameManager characterManager;
        [HideInInspector]
        public static IGameManager settingsManager;
         
        private void Start()
        {
            companyManager = companyManager??new CompanyManager();
            characterManager = characterManager??new CharacterManager();
            settingsManager = settingsManager??new SettingsManager();
        }
    }
}
