using System;
using DG.Tweening;
using UnityEngine;

public interface IAnimatable
{
    public Tween PlayAnimation(Transform target, float duration, Action callback = null);
}
