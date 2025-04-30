using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.1f;
    [SerializeField] private float _maxScale = 2f;

    private void Update()
    {
        ScaleObject();
    }

    private void ScaleObject()
    {
        if(transform.localScale.x < _maxScale)
            transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
