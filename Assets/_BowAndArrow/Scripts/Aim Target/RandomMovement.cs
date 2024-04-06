using UnityEngine;
using System.Collections;
public class RandomMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Move the GameObject along the X-axis randomly
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Check if the GameObject is out of bounds, and change direction if needed
        CheckBounds();
    }

    void CheckBounds()
    {
        float screenWidth = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;

        // If the GameObject goes out of the screen bounds, change direction
        if (transform.position.x < -screenWidth / 2 || transform.position.x > screenWidth / 2)
        {
            speed = -speed;
        }
    }
}
