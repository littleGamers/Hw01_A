using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Speed can be changed from the GUI.
    [SerializeField]
    float speed = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        // Rotate the object in the Z axis.
        // You can rotate the on other axis by switching between the cordinates order.
        transform.Rotate(0, 0, 0.5f);
    }
}
