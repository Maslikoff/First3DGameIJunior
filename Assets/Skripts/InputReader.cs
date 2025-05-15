using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public event Action MouseLeftCliked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MouseLeftCliked?.Invoke();
    }
}
