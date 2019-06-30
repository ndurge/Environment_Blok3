using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSpriteSize : MonoBehaviour
{

    void OnValidate()
    {
        var renderer = GetComponent<SpriteRenderer>();
        var collider = GetComponent<BoxCollider2D>();

        collider.size = new Vector2(
            renderer.size.x,
            renderer.size.y
        );
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
