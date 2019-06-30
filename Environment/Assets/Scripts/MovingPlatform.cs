using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    Vector3 from;
    public Vector3 to;

    float time = 0;
    public float waitTime = 1;
    bool pleaseWait = false;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //to = transform.position + to;
        from = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pleaseWait) return;

        time += Time.deltaTime * speed;

        if (time >= 1)
        {
            time = 1;
            pleaseWait = true;
            Invoke("PleaseContinue", waitTime);
        }

        transform.position = Vector3.Lerp(from, to, Ease(time));
    }

    void PleaseContinue()
    {
        Vector3 swap = from;
        from = to;
        to = swap;
        time = 0;
        pleaseWait = false;
    }

    float Ease(float t)
    {
        return (1 + Mathf.Sin(Mathf.PI * t - Mathf.PI / 2)) / 2;
    }
}