using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 offset2;
    private Vector3 up = Vector3.up;
    public GameObject cam;
    public bool camchange;
    public GameObject ball;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
        
    }
}
