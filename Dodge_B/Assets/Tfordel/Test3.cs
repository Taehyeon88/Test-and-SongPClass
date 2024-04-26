using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string space1 = "";
        string space2 = "";
        string stars = "";

        for (int i = 0; i < 10; i++)
        {
            
            for(int j = 0; j <(10-i) ; j++)
            {
                space1 += " ";
                space2 += " ";
            }
            stars += "*";
            Debug.Log(space1 + stars + space2);
            space1 = "";
            space2 = "";

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
