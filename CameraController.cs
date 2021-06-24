using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal")*speed, 0, Input.GetAxis("Vertical")*speed);
        transform.RotateAround(target.transform.position, target.transform.up, Input.GetAxis("Horizontal") * speed);
        transform.RotateAround(target.transform.position, target.transform.right, Input.GetAxis("Vertical") * speed);
    }
}
