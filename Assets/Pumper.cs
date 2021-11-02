using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumper : MonoBehaviour
{
    // 'maxSize' and 'speed' are used to control the size limit and pumping speed.
    [SerializeField]
    float speed = 2.0f;
    [SerializeField]
    float maxSize = 3.0f;

    void Start()
    {
    }

    void Update()
    {
        // Calculate the new object's size:
        // Time.time is increasing every moment so Sin() is moving betwwen -1 to 1 constantly.
        // We get that: -maxSize < size < maxSize.
        float size = maxSize * Mathf.Sin(Time.time * speed);

        // We want to object's scale to be betwwen 0 and maxSize so we'll use it's absolute value.
        transform.localScale = new Vector3(Mathf.Abs(size), Mathf.Abs(size), Mathf.Abs(size));
    }
}
