using UnityEngine;

public class MainScene : SceneBase
{
    public override void OnEnter()
    {
        base.OnEnter();
        
        
        Debug.Log("EnterMainScene");
    }

    public override void OnExit()
    {
        base.OnExit();
        
        CoroutineManager.Instance.StopAllCoroutines();
    }
}