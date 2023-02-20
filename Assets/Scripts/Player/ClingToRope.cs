using UnityEngine;

[RequireComponent(typeof(DistanceJoint2D))]
public class ClingToRope : MonoBehaviour
{
    [SerializeField] private UnhookFromRope _unhookFromRope;

    private DistanceJoint2D _joint;

    public bool InFreeFall => _joint.enabled == false;

    private void Start()
    {
        _joint= GetComponent<DistanceJoint2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EndOfRope endOfRope) && InFreeFall)
        {
            _joint.enabled = true;
            _joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            _unhookFromRope.SetCurrentRope(endOfRope);
        }
    }
}
