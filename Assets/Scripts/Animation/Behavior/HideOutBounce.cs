using System;
using DG.Tweening;
using UnityEngine;

public class HideOutBounce : IAnimatable
{
    public Tween PlayAnimation(Transform target, float duration, Action callback)
    {
        target.localScale = Vector3.one;
        return target.DOScale(0f, duration).SetEase(Ease.OutBounce).OnComplete(() => { callback?.Invoke(); });
    }
}