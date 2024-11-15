using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float rotate_speed = 15.0f;

    void Update()
    {
        transform.Rotate(0, 0, rotate_speed * Time.deltaTime);
    }
}
