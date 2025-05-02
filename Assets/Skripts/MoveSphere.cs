using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private void Update()
    {
        MovingObject();
    }

    private void MovingObject()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
