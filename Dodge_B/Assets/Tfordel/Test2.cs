using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string space = "";
        string stars = "";
        for(int i = 0; i <10; i++)
        {
            for(int j = 0; j < 10-i; j++)
            {
             space += " ";

            }
            stars += "*";
            Debug.Log(space + stars);
            space = "";
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
