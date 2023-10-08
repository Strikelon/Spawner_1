using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 _direction;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        transform.position += _direction * Time.deltaTime;
    }
}
