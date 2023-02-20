using System.Collections;
using UnityEngine;

[RequireComponent(typeof(DistanceJoint2D))]
public class UnhookFromRope : MonoBehaviour
{
    [SerializeField] private EndOfRope _currentRope;

    private DistanceJoint2D _joint;

    private void Start()
    {
        _joint = GetComponent<DistanceJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentRope.enabled = false;
            StartCoroutine(Waiting(_currentRope));
            _joint.connectedBody = null;
            _joint.enabled = false;
        }
    }

    private IEnumerator Waiting(EndOfRope endOfRope)
    {
        yield return new WaitForSeconds(1f);

        endOfRope.enabled = true;
    }

    public void SetCurrentRope(EndOfRope endOfRope)
    {
        _currentRope = endOfRope;
    }
}
