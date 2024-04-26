using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int output = 0;
        
        for(int i = 0; i < 10; i++)
        {
            int z = i;
            z *= z;
            Debug.Log(z);
            output += z;
        }
        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
