using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nhảy
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal"); // A D / ← →
        float z = Input.GetAxis("Vertical");   // W S / ↑ ↓

        Vector3 force = new Vector3(x, 0f, z) * moveForce;
        rb.AddForce(force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
