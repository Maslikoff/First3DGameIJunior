using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public event Action MouseCliked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MouseCliked?.Invoke();
    }
}
