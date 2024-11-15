using System;
using DG.Tweening;
using UnityEngine;

public class UpScaleBounceOut : IAnimatable
{
    public Tween PlayAnimation(Transform target, float duration, Action callback)
    {
        target.localScale = Vector3.one;
        return target.DOScale(new Vector3(1.5f, 1.5f, 1.5f), duration)
            .SetEase(Ease.OutBounce)
            .OnComplete(() => { callback?.Invoke(); });
    }
}