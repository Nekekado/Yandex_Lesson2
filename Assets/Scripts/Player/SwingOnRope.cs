using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SwingOnRope : MonoBehaviour
{
    [SerializeField] private float _swiningPower;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(xAxis, 0);

        _rigidbody2D.AddForce(direction * _swiningPower);
    }
}
