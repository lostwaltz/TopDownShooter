using Constants;
using DG.Tweening;
using UnityEngine;

public class DataManager : SingletonDontDestroy<DataManager>
{
     public DataBase<ItemData> ItemData { get; private set; }
     public DataBase<ShipData> ShipData { get; private set; }

     public void Init()
     {
          var itemDataList = Resources.Load<SO.ItemDataList>
               (Utils.Str.Clear().Append(Path.DataPath).Append("ItemDataList").ToString()).itemDataList;
          ItemData = new DataBase<ItemData>(itemDataList);
          
          var shipDataList = Resources.Load<SO.ShipDataList>
               (Utils.Str.Clear().Append(Path.DataPath).Append("ShipDataList").ToString()).shipDataList;
          ShipData = new DataBase<ShipData>(shipDataList);
     }
}