using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public float minX = 0;
    public float minY = 0;
    public float maxX = 100;
    public float maxY = 100;

    void Start()
    {
    }

    void Update()
    {
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
        else if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }
}