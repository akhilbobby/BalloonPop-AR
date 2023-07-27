using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    private float heightThreshold = 4f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
        if (transform.position.y > heightThreshold)
        {
            Destroy(gameObject);
        }
    }
}
