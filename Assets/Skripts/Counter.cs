using UnityEngine;
using TMPro;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private float _pauseTime = .5f;

    private int _counterValue = 0;

    private bool _isCounting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            ClickStartStop();
    }

    private void ClickStartStop()
    {
        if (_isCounting)
        {
            _isCounting = false;
            StopCoroutine(CountEveryHalfSecond());

            Debug.Log("Counter stopped at: " + _counterValue);
        }
        else
        {
            _isCounting = true;
            StartCoroutine(CountEveryHalfSecond());

            Debug.Log("Counter started");
        }
    }

    private IEnumerator CountEveryHalfSecond()
    {
        while (_isCounting)
        {
            yield return new WaitForSeconds(_pauseTime);
            Ñalculation();
            PrintText();
        }
    }

    private void Ñalculation()
    {
        _counterValue++;
    }

    private void PrintText()
    {
        if (_counterText != null)
            _counterText.text = _counterValue.ToString();
    }
}
