using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Player _player;

    private ShipData ShipData => _player.ShipData;
    
    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        transform.position += transform.transform.forward * (ShipData.shipSpeed * Time.deltaTime);
    }
}
