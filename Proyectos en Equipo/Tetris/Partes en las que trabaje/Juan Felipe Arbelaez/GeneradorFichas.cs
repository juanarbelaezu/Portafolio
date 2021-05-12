using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorFichas : MonoBehaviour
{
    [SerializeField] GameObject[] fichas;
    [SerializeField] GameObject spawn;

    public static int sig_ficha = 7;

    public static bool fichaactiva;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fichaactiva == false)
        {
            InstanciarFichas();
        }
    }

    void InstanciarFichas()
    {
        if(sig_ficha == 7)
        {
            Instantiate(fichas[Random.Range(0, fichas.Length)], spawn.transform.position, spawn.transform.rotation);
            sig_ficha = Random.Range(0, 7);
        }
        else if(sig_ficha != 7)
        {
            Instantiate(fichas[sig_ficha], spawn.transform.position, spawn.transform.rotation);
        }
    }
}
