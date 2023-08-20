using Sirenix.OdinInspector;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(fileName = "AreaSO",menuName = "SO/Area SO")]
    public class AreaSO : SaveableSO<AreaSaveableData>
    {
        [Header("Fixed Data")]
        [AssetsOnly][GUIColor(0f,0.75f,0f)]
        public GameObject AreaPrefab;
    }
}