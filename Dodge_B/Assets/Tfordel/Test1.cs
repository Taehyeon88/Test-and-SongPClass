using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] stars = { "*", "*", "*", "*", "*", "*", "*", "*", "*", };
        string sum = "";

        foreach (string s in stars)
        {
            sum += s;
            Debug.Log(sum);
        }
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
