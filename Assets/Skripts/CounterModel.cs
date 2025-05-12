using System.Collections;
using UnityEngine;

public class CounterModel : MonoBehaviour
{
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
        _isCounting = true;

        if (_countingCoroutine != null)
            StopCoroutine(_countingCoroutine);

        _countingCoroutine = StartCoroutine(CountingRoutine());
    }

    private void StopCounting()
    {
        _isCounting = false;

        if (_countingCoroutine != null)
            StopCoroutine(_countingCoroutine);
    }

    private IEnumerator CountingRoutine()
    {
        var wait = new WaitForSeconds(_pauseTime);

        while (_isCounting)
        {
            _counterValue++;

            yield return wait;
        }

    }
}
