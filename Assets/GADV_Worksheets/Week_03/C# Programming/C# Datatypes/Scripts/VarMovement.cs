using UnityEngine;

public class VarMovement : MonoBehaviour
{
    private void Update()
    {
        float x = 5;
        int y = (int)x;

        var speed = 5.0f; // Inferred as float
        var direction = new Vector3(1, 0, 0); // Inferred as Vector3

        transform.position += direction * speed * Time.deltaTime;
        // speed = "fast"; 
    }
}
