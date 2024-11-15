using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpawnEffects : MonoBehaviour
{
    [SerializeField] private GameObject spawnVFX;
    [SerializeField] private float animationDuration = 1f;

    [SerializeField] private List<AnimatableFactory> animatableFactoryList;
    private readonly List<IAnimatable> _effects = new();
    
    private void Start()
    {
        foreach (var factory in animatableFactoryList)
            _effects.Add(factory.CreateAnimationEffects());

        PlayEffects();
    }

    public void PlayEffects()
    {
        foreach (var animatable in _effects)
            animatable.PlayAnimation(transform, animationDuration);
        
        if (spawnVFX != null)
            Instantiate(spawnVFX, transform.position, Quaternion.identity);

        if(true == TryGetComponent<AudioSource>(out AudioSource audioSource))
            audioSource.Play();
    }

    private void PlayAnimation(int index)
    {
        _effects[index].PlayAnimation(transform, animationDuration).OnComplete(() =>
        {
            PlayAnimation(index + 1);
        });
    }
}