using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Player player;
    
    private InputReader _input;
    private Camera _mainCamera;
    
    private Vector3 _lookDirection;
    
    
    
    private void Start()
    {
        _mainCamera = Camera.main;
        
        _input = player.InputReader;
        
        _input.Look += CallBackLookDirection;
    }

    private void Update()
    {
    }

    private void CallBackLookDirection(Vector2 mousePosition)
    {
        Vector3 mouseScreenPos = new Vector3(mousePosition.x, mousePosition.y, _mainCamera.transform.position.y);
        Vector3 mouseWorldPos = _mainCamera.ScreenToWorldPoint(mouseScreenPos);
        
        transform.position = mouseWorldPos;
    }
}
