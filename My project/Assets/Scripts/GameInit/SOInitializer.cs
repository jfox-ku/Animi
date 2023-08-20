using System.Collections.Generic;
using SO;
using UnityEngine;

namespace GameInit
{
    public class SOInitializer : MonoBehaviour
    {
        [SerializeField]
        public List<SaveableSO<SaveableData>> SOs;
    }
}