using System.Collections.Generic;
using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "ShipData", menuName = "Data/ShipData")]
    public class ShipDataList : ScriptableObject
    {
        [SerializeField] public List<ShipData> shipDataList = new();
    }   
}
