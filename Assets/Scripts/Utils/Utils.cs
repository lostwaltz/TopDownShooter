using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class Utils
{
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        return FindChild<Transform>(go, name, recursive).gameObject;
    }

    public static T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if(go == null) return null;

        if (recursive == false)
        {
            for (var i = 0; i < go.transform.childCount; i++)
            {
                Transform transform = go.transform.GetChild(i);

                if (!string.IsNullOrEmpty(name) && transform.name != name) continue;

                T component = transform.GetComponent<T>();

                if (component != null) return component;
            }
        }
        else
        {
            return go.GetComponentsInChildren<T>()
                .FirstOrDefault(component => string.IsNullOrEmpty(name) || component.name == name);
        }

        return null;
    }

}