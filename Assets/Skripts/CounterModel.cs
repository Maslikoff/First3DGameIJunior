using System;
using System.Collections;
using UnityEngine;

public class CounterModel : MonoBehaviour
{
    [SerializeField] private float _pauseTime = 0.5f;

    private Coroutine _countingCoroutine;
    private WaitForSeconds _wait;
    private int _counterValue = 0;

    private bool _isCounting = false;

    public event Action<int> CountChanged;

    private void Awake()
    {
        _wait = new WaitForSeconds(_pauseTime);
    }

    public void ToggleCounting()
    {
        if (_isCounting)
            StopCounting();
        else
            StartCounting();
    }

    private void StartCounting()
    {
        _isCounting = true;

        _countingCoroutine = StartCoroutine(CountingRoutine());
    }

    private void StopCounting()
    {
        if (_isCounting == false) 
            return;

        _isCounting = false;

        CountChanged?.Invoke(_counterValue);

        if (_countingCoroutine != null)
            StopCoroutine(_countingCoroutine);
    }

    private IEnumerator CountingRoutine()
    {
        while (_isCounting)
        {
            _counterValue++;
            CountChanged?.Invoke(_counterValue);

            yield return _wait;
        }
    }
}