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
        _counterModel.CountChanged += UpdateCounterText;
    }

    private void OnDisable()
    {
        _counterModel.CountChanged -= UpdateCounterText;
    }

    private void UpdateCounterText(int count)
    {
        _counterText.text = count.ToString();
    }
}