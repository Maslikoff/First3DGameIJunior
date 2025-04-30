using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        MovingObject();
    }

    private void MovingObject()
    {
        _startPosition.x += _moveSpeed * Time.deltaTime;
        transform.position = _startPosition;
    }
}
