using UnityEngine;

public class CounterController : MonoBehaviour
{
    private InputReader _inputReader;
    private CounterModel _counterModel;

    private void Awake()
    {
        _inputReader = FindObjectOfType<InputReader>();
        _counterModel = GetComponent<CounterModel>();
    }

    private void OnEnable()
    {
        _inputReader.MouseLeftCliked += OnMouseLeftClicked;
    }

    private void OnDisable()
    {
        _inputReader.MouseLeftCliked -= OnMouseLeftClicked;
    }

    private void OnMouseLeftClicked()
    {
        _counterModel.ToggleCounting();
        Debug.Log(_counterModel.IsCounting
            ? $"Counter started at: {_counterModel.CounterValue}"
            : $"Counter stopped at: {_counterModel.CounterValue}");
    }
}
