using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.125f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    private Camera camera;
    private void Start()
    {
        camera = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, smoothTime);
    }
}
