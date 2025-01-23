using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 10f;
    private float _gravity = 9.81f;
    private float _forwardSpeed = 5f; // 前進速度

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
        float horizontalInput = Input.GetAxis("Horizontal"); // 只讀取水平輸入(A/D)
        Vector3 direction = new Vector3(horizontalInput, 0, 1); // z軸設為1，實現持續前進
        Vector3 velocity = direction * _speed;
        velocity.z = _forwardSpeed; // 使用固定的前進速度
        velocity.y -= _gravity;
        _controller.Move(velocity * Time.deltaTime);
    }
}