using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject westExit;
    public GameObject eastExit;

    public bool northOn, southOn, westOn, eastOn;

    // Start is called before the first frame update
    void Start()
    {
        if (//location is room 1);
        {
            this.northExit.SetActive(false);
        }
 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
