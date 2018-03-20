using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 offset2;

    public GameObject cam;

    public GameObject ball;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        if (ball.transform.position.z >= 0)
        {

            Vector3 desiredPosition2 = target.position + offset2;
            Vector3 smoothedPosition2 = Vector3.Lerp(transform.position, desiredPosition2, smoothSpeed);
            Vector3 smoothedRotation2 = new Vector3(30, 117, 1);

            transform.position = smoothedPosition2;
            transform.Rotate(smoothedRotation2);
        }
        
    }




}
