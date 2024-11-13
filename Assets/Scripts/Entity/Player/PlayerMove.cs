using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private void Update()
    {
        transform.position += transform.transform.forward * (100f * Time.deltaTime);
    }
}
