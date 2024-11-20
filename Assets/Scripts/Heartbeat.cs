using System;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    [Tooltip("The base scale for the object's size.")]
    [SerializeField]
    private float base_scale = 1.0f;

    [Tooltip("The speed in which the object inflates.")]
    [SerializeField]
    private float speed = 1.0f;

    [Tooltip("The size increase when the object inflates.")]
    [SerializeField]
    private float inflate_size = 0.2f;

    [Tooltip("The frequency in which the heart inflates.")]
    [SerializeField]
    private float frequency = Mathf.PI;

    // Update is called once per frame
    void Update()
    {
        // Heartbeats are not as constant as a sin(x) function.
        // In order to simulate them better, we calculate the current inflation state using |sin(t*s*f)|.
        float inflate_state = Mathf.Abs(Mathf.Sin(Time.time * speed * frequency));

        // Scaling the object accordingly
        float scale = base_scale + inflate_state * inflate_size;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}