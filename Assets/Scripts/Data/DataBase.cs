using System;
using System.Collections.Generic;
using UnityEditor;

public class DataBase<T>  where T : DataModel
{
    public DataBase(List<T> list)
    {
        GenerateDbFromList(list);
    }
    
    private readonly Dictionary<int ,T> _dataBaseDictionary = new();

    private void GenerateDbFromList(List<T> list)
    {
        foreach (var data in list)
            _dataBaseDictionary.Add(data.ID, data);
    }

    public T Get(int id)
    {
        _dataBaseDictionary.TryGetValue(id, out T data);
        
        return data;
    }
}
