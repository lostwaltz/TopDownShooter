using Constants;
using UnityEngine;

public class DataManager : SingletonDontDestroy<DataManager>
{
     public DataBase<ItemData> ItemData { get; private set; }

     public void Init()
     {
          var itemDataList = Resources.Load<SO.ItemDataList>(Path.DataPath + "ItemData").itemDataList;
          ItemData = new DataBase<ItemData>(itemDataList);
     }
}