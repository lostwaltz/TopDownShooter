using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Transform tiltTransform;
    
    private InputReader _input;
    private Camera _mainCamera;
    
    public float rotationSpeed = 5f; // 회전 속도
    public float maxTiltAngle = 15f; // 최대 틸트 각도
    public float tiltSpeed = 10f;
    private float currentTilt = 0f;
    
    
    private void Start()
    {
        _mainCamera = Camera.main;

        _input = player.InputReader;
        
        //_input.Look += CallBackLookDirection;
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
        
        float tiltDirection = rotationSpeed * Time.deltaTime * Mathf.Sign(targetDirection.x);
        float targetTilt = -targetDirection.x * maxTiltAngle;

        // 현재 틸트 각도를 부드럽게 보간
        currentTilt = Mathf.Lerp(currentTilt, targetTilt, tiltSpeed * Time.deltaTime);

        Debug.Log(targetTilt);
        Debug.Log(currentTilt);
        
        // 틸트 적용 (Z축 기준)
        if (tiltTransform != null)
        {
            tiltTransform.localRotation = Quaternion.Euler(0f, 0f, currentTilt);
        }
    }
}
