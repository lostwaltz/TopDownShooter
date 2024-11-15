using System;
using DG.Tweening;
using UnityEngine;

public class ShakePosition : IAnimatable
{
    public Tween PlayAnimation(Transform target, float duration, Action callback)
    {
        return target.DOShakePosition(duration, 10f);
    }
}