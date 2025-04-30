using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Update()
    {
        // Move the animals on the vertical axis at the speed set by the float "speed"
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
