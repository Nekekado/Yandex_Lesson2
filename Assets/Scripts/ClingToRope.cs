using UnityEngine;

public class ClingToRope : MonoBehaviour
{
    private DistanceJoint2D joint;
    private bool inFreeFall;

    private void Start()
    {
        joint= GetComponent<DistanceJoint2D>();
    }

    private void Update()
    {
        inFreeFall = joint.enabled == false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EndOfRope" && inFreeFall) 
        {
            joint.enabled = true;
            joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
