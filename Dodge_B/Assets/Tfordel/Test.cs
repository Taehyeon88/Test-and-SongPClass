using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int[] numbers = { 10, 33, 48, 305 };
    int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbers.Length; ++i)
        {
            sum += numbers[i];
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
