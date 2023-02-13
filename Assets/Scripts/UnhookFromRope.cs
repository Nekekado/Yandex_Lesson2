using UnityEngine;

public class UnhookFromRope : MonoBehaviour
{
    private DistanceJoint2D joint;

    private void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            joint.connectedBody = null;
            joint.enabled = false;
        }
    }
}
