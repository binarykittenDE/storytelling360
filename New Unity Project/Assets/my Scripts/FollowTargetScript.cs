using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class FollowTargetScript : MonoBehaviour
{
    public Transform imageTarget;

    //Smoothing variables
    public float smoothTime = 0.2F;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = imageTarget.TransformPoint(new Vector3(0, 0, 2));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
