using System;
using System.Collections;
using UnityEngine;

public class CounterModel : MonoBehaviour
{
    public event Action OnCountChanged;

    [SerializeField] private float _pauseTime = 0.5f;

    private Coroutine _countingCoroutine;
    private int _counterValue = 0;

    private bool _isCounting = false;

    public int CounterValue => _counterValue;
    public bool IsCounting => _isCounting;

    public void ToggleCounting()
    {
        if (_isCounting)
            StopCounting();
        else
            StartCounting();
    }

    private void StartCounting()
    {
        if (_isCounting) return;

        _isCounting = true;

        _countingCoroutine = StartCoroutine(CountingRoutine());
    }

    private void StopCounting()
    {
        if (_isCounting == false) return;

        _isCounting = false;

        OnCountChanged?.Invoke();

        if (_countingCoroutine != null)
            StopCoroutine(_countingCoroutine);
    }

    private IEnumerator CountingRoutine()
    {
        var wait = new WaitForSeconds(_pauseTime);

        while (_isCounting)
        {
            _counterValue++;
            OnCountChanged?.Invoke();

            yield return wait;
        }
    }
}