using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceHide : MonoBehaviour
{
    // Keep our renderer because it controls the object's visibility.
    SpriteRenderer renderer;

    void Start()
    {
        // Get the SpriteRenderer from the object:
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // If the SPACE key is pressed, the rednderer will be enabled/disabled.
        // In other words, SPACE is used to Show/Hide the object.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            renderer.enabled = !renderer.enabled;
        }
    }
}
