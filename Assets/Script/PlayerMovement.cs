using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 10f;
    private float _gravity = 9.81f;
    private float _forwardSpeed = 5f; // �e�i�t��

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // �uŪ��������J(A/D)
        Vector3 direction = new Vector3(horizontalInput, 0, 1); // z�b�]��1�A��{����e�i
        Vector3 velocity = direction * _speed;
        velocity.z = _forwardSpeed; // �ϥΩT�w���e�i�t��
        velocity.y -= _gravity;
        _controller.Move(velocity * Time.deltaTime);
    }
}