using System;
using UnityEngine;

namespace SO
{
    [Serializable]
    public class SaveableSO<T> : ScriptableObject where T : SaveableData
    {
        public string SaveID;
        public T SavedData;

        public virtual void Save()
        {
            
        }

        public virtual void Load()
        {
            
        }
    }
}