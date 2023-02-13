using UnityEngine;

public class SwingOnRope : MonoBehaviour
{
    [SerializeField] private float swiningPower;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(xAxis * swiningPower, 0);

        rb.AddForce(direction, ForceMode2D.Force);
    }
}
