using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private MouseButton _mouseButton = MouseButton.Left;

    public event Action MouseCliked;

    private void Update()
    {
        if (Input.GetMouseButtonDown((int)_mouseButton))
            MouseCliked?.Invoke();
    }
}