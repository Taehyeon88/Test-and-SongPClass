using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int output = 1;
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            output = output * 2;
            Debug.Log(output);
            sum += output;
        }
        Debug.Log(sum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
