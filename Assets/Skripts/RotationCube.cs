using UnityEngine;

public class RotationCube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 10f;

    private void Update()
    {
        RotationObject();
    }

    private void RotationObject()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
