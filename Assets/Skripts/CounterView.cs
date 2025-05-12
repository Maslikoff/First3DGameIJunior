using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private CounterModel _counterModel;

    private void Start()
    {
        _counterModel = GetComponent<CounterModel>();
    }

    private void Update()
    {
        UpdateCounterText();

        if (Input.GetMouseButtonDown(0))
        {
            _counterModel.ToggleCounting();
            LogCounterState();
        }
    }

    private void UpdateCounterText()
    {
        if (_counterText != null)
            _counterText.text = _counterModel.CounterValue.ToString();
    }

    private void LogCounterState()
    {
        Debug.Log(_counterModel.IsCounting
            ? $"Counter started at: {_counterModel.CounterValue}"
            : $"Counter stopped at: {_counterModel.CounterValue}");
    }

    private void OnEnable()
    {
        UpdateCounterText();
    }
}
