using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public float minX = 0;
    public float minY = 0;
    public float maxX = 100;
    public float maxY = 100;

    public float offsetY = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Zet de local positie op 0 zodat het precies op de speler staat
        transform.localPosition = new Vector3(0, transform.localPosition.y, transform.localPosition.z);

        // Als de x position hoger is dan de max
        if (transform.position.x >= maxX)
        {
            // Zet de x positie gelijk aan de max zodat de camera niet verder dan de max gezet kan worden
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        // Als de x position lager is dan de min
        else if (transform.position.x <= minX)
        {
            // Zet de x positie gelijk aan de min zodat de camera niet verder dan de min gezet kan worden
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        // Zet de local y positie gelijk aan een offset, zodat de camera iets boven of onder de speler kan staan
        transform.localPosition = new Vector3(transform.localPosition.x, offsetY, transform.localPosition.z);

        // Als de y position hoger is dan de max
        if (transform.position.y >= maxY)
        {
            // Zet de y positie gelijk aan de max zodat de camera niet verder dan de max gezet kan worden
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
        // Als de y position lager is dan de mon
        else if (transform.position.y <= minY)
        {
            // Zet de y positie gelijk aan de min zodat de camera niet verder dan de min gezet kan worden
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }
}