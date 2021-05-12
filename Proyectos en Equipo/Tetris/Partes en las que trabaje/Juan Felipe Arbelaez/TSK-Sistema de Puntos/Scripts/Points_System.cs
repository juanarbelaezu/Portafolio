using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points_System : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] int combox;
    [SerializeField] TextMeshPro textpoints;
    [SerializeField] TextMeshPro textcombo;
    [SerializeField] ParticleSystem combo_partycle;
    [SerializeField] bool clear;

    public bool Clear { get => clear; set => clear = value; }
    public int Points { get => points; set => points = value; }

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        combox = 1;
        clear = false;
        textpoints.SetText(points.ToString());
        textcombo.SetText(combox.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (clear == true)
        {
            combo();
        }
    }

    public void pointup() // Metodo utilizado para elevar los puntos del jugador, cada que se ejecuta se suman 5 puntos multiplicado por el combo.
    {
        points += 5 * combox;
        textpoints.SetText(points.ToString());
    }

    public void combo() // Metodo utilizado para calcular la racha de combos del jugador, cada que se ejecuta suma 1 al multiplicador de combox y ejecuta un sistema de particulas, tambien se utiliza para limpiar el contador de combos si el jugador cale de la racha.
    {
        if (clear == true)
        {
            combox += 1;
            points += 5 * combox;
            clear = false;
            textcombo.SetText(combox.ToString());
            combo_partycle.Play();
        }
        else if (clear == false)
        {
            combox = 1;
            textcombo.SetText(combox.ToString());
        }
    }

    public void truecombo() /// Setear el bool de combo a true para que se sume a la racha.
    {
        clear = true;
    }
}
