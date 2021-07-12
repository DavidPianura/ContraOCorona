using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetGenerator : MonoBehaviour
{
    public Transform destructPoint;
    public Transform generationPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= destructPoint.position.x) {
            transform.position = generationPoint.position;
        }
        
    }
}
