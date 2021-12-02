using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class KeyboardInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        var directionMovement = Vector3.zero;

        if (Input.GetKey(InputOptions.MoveForward))
            directionMovement += Vector3.forward;
        if (Input.GetKey(InputOptions.MoveBackward))
            directionMovement += Vector3.back;
        if (Input.GetKey(InputOptions.MoveLeft))
            directionMovement += Vector3.left;
        if (Input.GetKey(InputOptions.MoveRight))
            directionMovement += Vector3.right;

        _playerMovement.Move(directionMovement);
    }
}
