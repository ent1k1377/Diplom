using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovement
{
    [SerializeField] private float _speed;
    
    public void Move(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}

