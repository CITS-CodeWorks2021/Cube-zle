using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 startingLocation;
    // Start is called before the first frame update
    void Start()
    {
        startingLocation = transform.position;
    }

}
