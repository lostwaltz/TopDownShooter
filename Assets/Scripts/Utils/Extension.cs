using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class Extension
{
    public static void BindEvent(this GameObject go, Action<PointerEventData> action, EnumTypes.UIEvent type = EnumTypes.UIEvent.Click)
    {
        UIBase.BindEvent(go, action, type);
    }
    public static float Clamp(this ref float value, float min, float max)
    {
        return value = Mathf.Clamp(value, min, max);
    }
    public static int Clamp(this ref int value, int min, int max)
    {
        return value = Mathf.Clamp(value, min, max);
    }
}