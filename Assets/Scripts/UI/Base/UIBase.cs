using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;


public abstract class UIBase : MonoBehaviour
{
    [SerializeField] private Transform animationRoot;
    [SerializeField] private AnimatableFactory showAnimatableFactory;
    [SerializeField] private AnimatableFactory hideAnimatableFactory;
    
    private IAnimatable _showEffects;
    private IAnimatable _hideEffects;
    
    public static void BindEvent(GameObject go, Action<PointerEventData> action, EnumTypes.UIEvent type = EnumTypes.UIEvent.Click)
    {
        UIEventHandler evt = go.GetOrAddComponent<UIEventHandler>();

        switch (type)
        {
            case EnumTypes.UIEvent.Click:
                evt.OnClickEvent -= action;
                evt.OnClickEvent += action;
                break;
            case EnumTypes.UIEvent.Drag:
                evt.OnDragEvent -= action;
                evt.OnDragEvent += action;
                break;
        }
    }

    public void Open()
    {
        gameObject.SetActive(true);

        if (animationRoot is null || showAnimatableFactory is null)
        {
            OpenProcedure();
            return;
        }

        _showEffects = showAnimatableFactory.CreateAnimationEffects();
        
        _showEffects.PlayAnimation(animationRoot, 0.3f, OpenProcedure);
    }

    public void Close()
    {
        if (animationRoot is null || hideAnimatableFactory is null)
        {
            CloseDone();
            return;
        }

        _hideEffects = hideAnimatableFactory.CreateAnimationEffects();
        _hideEffects.PlayAnimation(animationRoot, 0.3f, CloseDone);
    }

    private void CloseDone()
    {
        gameObject.SetActive(false);
        CloseProcedure();
    }

    protected virtual void OpenProcedure()
    {
        
    }
    
    protected virtual void CloseProcedure()
    {
        
    }
}
