using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;
    
    public InputReader InputReader => inputReader;
    public ShipData ShipData { get; private set; }

    public void Init(ShipData shipData)
    {
        ShipData = shipData;
        InputReader.EnablePlayerActions();
    }
}
