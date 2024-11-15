public class MainScene : SceneBase
{
    public override void OnEnter()
    {
        base.OnEnter();
        
        DataManager.Instance.Init();
    }

    public override void OnExit()
    {
        base.OnExit();
        
        CoroutineManager.Instance.StopAllCoroutines();
    }
}