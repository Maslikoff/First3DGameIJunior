using UnityEngine;

public class CrazyCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 30f;
    [SerializeField] private float _scaleSpeed = 0.1f;
    [SerializeField] private float _maxScale = 3f;

    private void Update()
    {
        Moving();
        Rotation();
        Growind();
    }

    private void Moving()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
    
    private void Rotation()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
    
    private void Growind()
    {
        if (transform.localScale.x < _maxScale)
            transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
