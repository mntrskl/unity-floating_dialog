using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed = 0.1f;
    public float time = 3f;
    public AnimationCurve curve;

    Camera cameraToLookAt;

    // Use this for initialization 
    void Start()
    {
        cameraToLookAt = Camera.main;

    }

    // Update is called once per frame 
    void LateUpdate()
    {
        Transform from = transform;
        Transform to = cameraToLookAt.transform;
        //transform.LookAt(cameraToLookAt.transform);
        //transform.rotation = Quaternion.LookRotation(cameraToLookAt.transform.forward);
        //transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, Time.time * speed);
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, curve.Evaluate(speed/4));
    }
}