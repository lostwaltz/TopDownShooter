using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Transform tiltTransform;
    
    private InputReader _input;
    private Camera _mainCamera;
    
    public float rotationSpeed = 5f; // 회전 속도
    
    
    private void Start()
    {
        _mainCamera = Camera.main;

        _input = player.InputReader;
    }

    private void Update()
    {
        ApplyLook(_input.MousePos);
    }

    private void ApplyLook(Vector2 mousePosition)
    {
        Vector3 mouseScreenPos = new Vector3(mousePosition.x, mousePosition.y, _mainCamera.transform.position.y);
        Vector3 mouseWorldPos = _mainCamera.ScreenToWorldPoint(mouseScreenPos);
        Vector3 targetDirection = (mouseWorldPos - transform.position).normalized;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDirection, Vector3.up), Time.deltaTime * 10f);
        
        // TODO: tilt apply
    }
}
