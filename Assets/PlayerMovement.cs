using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float speed;

    bool left, forward, backward, right;

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        if (left)
        {
            rb.AddForce(Vector3.left * speed);
            left = false;
        }
        if (forward)
        {
            rb.AddForce(Vector3.forward * speed);
            forward = false;
        }
        if (backward)
        {
            rb.AddForce(Vector3.back * speed);
            backward = false;
        }
        if (right)
        {
            rb.AddForce(Vector3.right * speed);
            right = false;
        }
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.A))
            left = true;
        if (Input.GetKey(KeyCode.W))
            forward = true;
        if (Input.GetKey(KeyCode.S))
            backward = true;
        if (Input.GetKey(KeyCode.D))
            right = true;
    }
}
