using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI description;
    private int tutorialphase;
    [SerializeField] Sprite[] tutorialimages;
    [SerializeField] Image actualimage;
    [SerializeField] GameObject startbutton;


    // Start is called before the first frame update
    void Start()
    {
        description.SetText("Bienvenido al tutorial, presiona barra espaciadora para continuar");
        tutorialphase = 1;
        startbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PhaseChange();
        }
    }

    public void PhaseChange() //Sirve para cambiar las fases del tutorial 
    {
        if(tutorialphase == 1)
        {
            description.SetText("Las fichas caeran desde la parte alta de la pantalla, utiliza las flechas izquierda y derecha para moverlas");
            actualimage.GetComponent<Image>().sprite = tutorialimages[0];
            tutorialphase = 2;
        }
        else if (tutorialphase == 2)
        {
            description.SetText("Utiliza la flecha de arriba para rotar las piezas");
            actualimage.GetComponent<Image>().sprite = tutorialimages[1];
            tutorialphase = 3;
        }
        else if (tutorialphase == 3)
        {
            description.SetText("Apila las piezas, cada que completes una linea esta desaparecera y aumentara tu puntuacion.");
            actualimage.GetComponent<Image>().sprite = tutorialimages[2];
            tutorialphase = 4;
        }
        else if (tutorialphase == 4)
        {
            description.SetText("Ten cuidado, perderas si las piezas alcanzan la parte alta de la pantalla, presiona espacio para reiniciar este turorial o presiona continuar para comenzar");
            actualimage.GetComponent<Image>().sprite = tutorialimages[3];
            startbutton.SetActive(true);
            tutorialphase = 5;
        }
        else if (tutorialphase == 5)
        {
            tutorialphase = 1;
            startbutton.SetActive(false);
            description.SetText("Bienvenido al tutorial, presiona barra espaciadora para continuar");
            actualimage.GetComponent<Image>().sprite = tutorialimages[4];
        }
    }
}
