using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnSection : MonoBehaviour
{
    public GameObject rowSel;
    private Collider[] cluster;
    public string pivotTag;
    private GameObject pivotBlock;
    public int Directional = 1;
    public Vector3 axis = Vector3.up;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        Debug.Log("turn");
        cluster = Physics.OverlapBox(rowSel.transform.position, rowSel.transform.localScale , rowSel.transform.rotation);
        foreach (Collider c in cluster)
        {
            if(c.gameObject.tag == pivotTag)
            {
                pivotBlock = c.gameObject;
                Debug.Log("Pivot Taken: " + c.gameObject.tag);
                Debug.DrawRay(transform.position, c.gameObject.transform.position, Color.blue);
            }
        }
        if(pivotBlock!=null)
        {
            
            foreach (Collider c in cluster)
            {
                
                if (c.gameObject.tag != "ignore")
                {
                    c.gameObject.transform.RotateAround(pivotBlock.transform.position, axis, (90 * Directional));
                }

            }

        }
        cluster = null;
        pivotBlock = null;
    }

}
