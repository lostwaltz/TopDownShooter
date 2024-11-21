using UnityEngine;

public class MainScene : SceneBase
{
    public override void OnEnter()
    {
        base.OnEnter();
        
        DataManager.Instance.Init();
        PlayerManager.Instance.Init(DataManager.Instance);
        
        Debug.Log(DataManager.Instance);
    }

    public override void OnExit()
    {
        base.OnExit();
        
        CoroutineManager.Instance.StopAllCoroutines();
    }
}