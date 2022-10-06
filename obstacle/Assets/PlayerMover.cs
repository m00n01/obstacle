using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour // Child func : Parent func. Parent --> Child
{        
        float xValue = 4f;
        float yValue = 0f;
        float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
       // transform.Translate(10,0,0); //Adds 1 to the x-axis. (x,y,z)
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(xValue,yValue,zValue); //Adds 1 to the x-axis. (x,y,z) [] 0.01**F** to allow decimals. Basically. No 0.01000000000000, just 0.01 
        

    }
}

//float, bool, var. decimals(f). true/false. whole number
