using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace SO
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Data/ItemData")]
    public class ItemDataList : ScriptableObject
    {
        [SerializeField] public List<ItemData> itemDataList = new();
    }
}