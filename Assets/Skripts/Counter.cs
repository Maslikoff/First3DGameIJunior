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
        ClickStartStop();
    }

    private void ClickStartStop()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopAllCoroutines();
                _isCounting = false;

                Debug.Log("Counter stopped at: " + _counterValue);
            }
            else
            {
                StartCoroutine(CountEveryHalfSecond());
                _isCounting = true;

                Debug.Log("Counter started");
            }
        }
    }

    private IEnumerator CountEveryHalfSecond()
    {
        yield return new WaitForSeconds(_pauseTime);
        _counterValue++;
        _counterText.text = _counterValue.ToString();
    }
}
