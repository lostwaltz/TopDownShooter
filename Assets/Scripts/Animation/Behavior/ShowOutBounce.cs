using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

public class ShowOutBounce : IAnimatable
{
    public Tween PlayAnimation(Transform target, float duration, Action callback)
    {
        target.localScale = Vector3.zero;
        return target.DOScale(1f, duration).SetEase(Ease.OutBounce).OnComplete(() => { callback?.Invoke(); });
    }
}