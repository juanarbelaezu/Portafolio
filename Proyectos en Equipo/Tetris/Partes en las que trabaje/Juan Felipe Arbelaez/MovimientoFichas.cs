using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFichas : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, 0, -90, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(0, 0, 90, Space.Self);
        }
    }
}
