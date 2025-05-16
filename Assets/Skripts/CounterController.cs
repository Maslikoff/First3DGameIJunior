using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private CounterModel _counterModel;

    private void Awake()
    {
        _counterModel = GetComponent<CounterModel>();
    }

    private void OnEnable()
    {
        _inputReader.MouseCliked += OnMouseLeftClicked;
    }

    private void OnDisable()
    {
        _inputReader.MouseCliked -= OnMouseLeftClicked;
    }

    private void OnMouseLeftClicked()
    {
        _counterModel.ToggleCounting();
    }
}