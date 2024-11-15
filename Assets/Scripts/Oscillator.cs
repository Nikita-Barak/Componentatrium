using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 start_pos;
    
    [Tooltip("Distance of movement from starting point in each direction.")]
    [SerializeField] float radius = 4.5f;
    
    [Tooltip("Speed of the object in either direction")]
    [SerializeField] float speed = 0.7f;
    
    void Start()
    {
        start_pos = transform.position;
    }

    void Update()
    {
        // Since we need to move between 2 points, we need a function that's changing between -1 and 1 constantly and in different slopes.
        // Also, because we want the object to start at 0 when initializing the game, Sin() is the best option to do so.
        float offset = Mathf.Sin(Time.time * speed) * radius;

        // All that is left is to add the calculated offset to the object's current position.
        transform.position = new Vector3(start_pos.x + offset, start_pos.y, start_pos.z);
    }
}
