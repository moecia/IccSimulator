using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Employee
{
    public class CharacterManager : MonoBehaviour, IGameManager
    {
        private List<Character> characters = new List<Character>();

        private static CharacterManager instance;

        public static CharacterManager Instance 
        {
            get
            {
                if (!instance)
                {
                    instance = new CharacterManager();
                }
                return instance;
            }
        }

        public void StartUp() 
        {
            instance = new CharacterManager();
        }

        public void Dispose()
        { 
        }

        private void Start()
        {
            
        }
    }
}
