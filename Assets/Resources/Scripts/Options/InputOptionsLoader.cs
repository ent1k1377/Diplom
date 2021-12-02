using UnityEngine;

public class InputOptionsLoader : MonoBehaviour
{
    [Header("Player input Settings")]
    [Space()]
    
    [SerializeField] private KeyCode _moveForward;
    [SerializeField] private KeyCode _moveBackward;
    [SerializeField] private KeyCode _moveLeft;
    [SerializeField] private KeyCode _moveRight;
    [SerializeField] private KeyCode _jump;
    [SerializeField] private KeyCode _crouch;
    [SerializeField] private KeyCode _interact;

    private void Awake()
    {
        InputOptions.MoveForward = _moveForward;
        InputOptions.MoveBackward = _moveBackward;
        InputOptions.MoveLeft = _moveLeft;
        InputOptions.MoveRight = _moveRight;
        InputOptions.Jump = _jump;
        InputOptions.Crouch = _crouch;
        InputOptions.Interact = _interact;
    }
}