using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private List<turnSection> turns = new List<turnSection>();

    public List<Collider> check = new List<Collider>();
    private List<Collider[]> faces = new List<Collider[]>();

    private List<Cube> cubes = new List<Cube>();

    public int numberOfRndTurns = 10;
    private bool gameStart = false;
    // Start is called before the first frame update
    void Start()
    {
        turnSection[] t = GameObject.FindObjectsOfType<turnSection>();
        foreach( turnSection ts in t )
        {
            turns.Add(ts);
        }

        Cube[] c = GameObject.FindObjectsOfType<Cube>();
        foreach (Cube cb in c)
        {
            cubes.Add(cb);
        }

        foreach( Collider ch in check )
        {
            faces.Add(Physics.OverlapBox(ch.transform.position, ch.transform.localScale, ch.transform.rotation));
        }

        //Shuffle Cube
        StartCoroutine(shuffle());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckForWin()
    {
        for( int i = 0; i< check.Count -1; i++)
        {
            Collider[] quickCheck = Physics.OverlapBox(check[i].transform.position, check[i].transform.localScale, check[i].transform.rotation);
            
            for faces[i].Length

        }
    }

    IEnumerator shuffle()
    {
        for (int i = 0; i < numberOfRndTurns; i++)
        {
            int sh = Random.Range(0, turns.Count - 1);
            turns[sh].OnButtonPress();
            yield return new WaitForSeconds(.1f);
        }
        gameStart = true;
        
        
    }
}
