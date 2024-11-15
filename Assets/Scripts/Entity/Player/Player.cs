using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputReader inputReader; 
    public InputReader InputReader => inputReader;
    
    private void Awake()
    {
        InputReader.EnablePlayerActions();
    }
}
