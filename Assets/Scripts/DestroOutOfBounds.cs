using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy game object offscreen
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBound) {
            Destroy(gameObject);
        }
    }
}
