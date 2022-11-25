using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstats : MonoBehaviour
{

    public HPBar hpBar;
    int hpvalue = 100;
    int hpMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hpvalue -= 20;
            hpBar.SetValue(hpvalue);
        }
    }
}
