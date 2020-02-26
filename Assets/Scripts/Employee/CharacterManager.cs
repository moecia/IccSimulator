using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Employee
{
    public class CharacterManager : IGameManager
    {
        private List<Character> characters = new List<Character>();

        public void Dispose()
        { 
        }
    }
}
