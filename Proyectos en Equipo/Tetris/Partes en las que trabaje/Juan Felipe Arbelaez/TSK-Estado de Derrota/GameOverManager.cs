using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gamescreen;
    [SerializeField] GameObject gameoverscreen;
    [SerializeField] GameObject highScoreTable;
    [SerializeField] HighScoreManager hg_manager;
    [SerializeField] int finalScore;
    [SerializeField] TextMeshProUGUI textendpoints;

    [SerializeField] bool isGameOver;

    private Points_System points;

    public int FinalScore { get => finalScore; set => finalScore = value; }


    // Start is called before the first frame update
    void Start()
    {
        finalScore = 0;
        isGameOver = false;
    }

    void Awake()
    {
        points = GameObject.Find("points").GetComponent<Points_System>();
        hg_manager = GameObject.Find("GameManager").GetComponent<HighScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }

    public void EndGame() ///Activa la pantalla de game over y muestra el puntaje logrado.
    {
        finalScore = points.Points;
        textendpoints.SetText(finalScore.ToString());
        gamescreen.SetActive(false);
        gameoverscreen.SetActive(true);
        isGameOver = true;
        hg_manager.AddScore();
    }
    public void ShowLeaderboard()
    {
        highScoreTable.SetActive(true);
    }
}
