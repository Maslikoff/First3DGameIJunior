using UnityEngine;
using TMPro;

[RequireComponent(typeof(CounterModel))]
public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private CounterModel _counterModel;

    private void Awake()
    {
        _counterModel = GetComponent<CounterModel>();
    }

    private void OnEnable()
    {
        _counterModel.OnCountChanged += UpdateCounterText;
        UpdateCounterText();
    }

    private void OnDisable()
    {
        _counterModel.OnCountChanged -= UpdateCounterText;
    }

    private void Update()
    {
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
}