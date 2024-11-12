using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static InputActions;

[CreateAssetMenu(fileName = "InputReader", menuName = "ScriptableObject/InputReader")]
public class InputReader : ScriptableObject, IPlayerActions
{
    private InputActions _inputActions;

    #region EVENT
    public event UnityAction<Vector2> Look = delegate { };
    

    #endregion
    
    private void OnEnable()
    {
        if(_inputActions != null)
            return;
        
        _inputActions = new InputActions();
        _inputActions.Player.SetCallbacks(this);
    }

    public void EnablePlayerActions()
    {
        _inputActions.Enable();
    }
    
    public void OnLook(InputAction.CallbackContext context)
    {
        Look.Invoke(context.ReadValue<Vector2>());
    }
}
