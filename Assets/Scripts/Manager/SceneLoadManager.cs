using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneLoadManager : SingletonDontDestroy<SceneLoadManager>
{
    public static EnumTypes.Scene CurrentScene { get; private set; } = EnumTypes.Scene.LobbyScene;
    public static EnumTypes.Scene PrevScene { get; private set; }
    public static EnumTypes.Scene NextScene { get; private set; }
    
    private readonly Dictionary<EnumTypes.Scene, SceneBase> _sceneDic = new();
    
    private Action<float> _onLoadingProgressUpdate;

    protected override void Awake()
    {
        base.Awake();
        
        _sceneDic.Add(EnumTypes.Scene.LobbyScene, new LobbyScene());
        _sceneDic.Add(EnumTypes.Scene.MainScene, new MainScene());
        
        _sceneDic[CurrentScene].OnEnter();
    }

    public void LoadScene(EnumTypes.Scene scene)
    {
        NextScene = scene;

        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        yield return null;
        
        AsyncOperation op = SceneManager.LoadSceneAsync(NextScene.ToString());
        if (op != null) op.allowSceneActivation = false;

        while (op is { isDone: false })
        {
            yield return null;

            _onLoadingProgressUpdate?.Invoke(op.progress);
            
            if(op.progress < 0.9f)
                continue;
                
            op.allowSceneActivation = true;
            
            PrevScene = CurrentScene;
            CurrentScene = NextScene;
        
            _sceneDic[PrevScene].OnExit();
            _sceneDic[CurrentScene].OnEnter();

            break;
        }
    }
}
