using System;

namespace SO
{
    [Serializable]
    public class AreaSaveableData : SaveableData
    {
        public bool IsUnlocked;
        public bool IsVisited;
    }
}