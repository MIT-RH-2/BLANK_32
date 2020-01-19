using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltRotation : MonoBehaviour
{

    public GameObject saltMonster;
    float y;
    float y_limit_max;
    float y_limit_min;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        y = saltMonster.transform.rotation.y;
        saltMonster.transform.Rotate(saltMonster.transform.rotation.x, y, saltMonster.transform.rotation.z);
        y_limit_max = y + 30;
        y_limit_min = y - 30;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(y == y_limit_max)
        {
            i = -1;
        }

        if (y == y_limit_min)
        {
            i = 1;
        }
        if(y < y_limit_max && y > y_limit_min)
        {
            y += i * Time.deltaTime;
        }
    }
}
