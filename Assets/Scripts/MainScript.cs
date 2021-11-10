using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
     
    public int buttonIncrement;
    public float timerLenght = 5;
    public GameObject gameLevelWindow;
    public GameObject submitButton;
    public GameObject buttonPrefabResource;
    public GameObject greenZoneContent;
    public GameObject redZoneContent;


    private float timerEnd;
    private int gameLevel = 1;
    private bool gameWon;
    private int nbOfButtons = 2;
    private List<ButtonScript> buttonsList;
     


    // Start is called before the first frame update
    void Start()
    {
        StartNewGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerateButtons()
    {
        for (int i = 0; i < nbOfButtons; i++)
        {
            GameObject newButton = Instantiate(buttonPrefabResource, greenZoneContent.transform);
            ButtonScript button = newButton.GetComponent<ButtonScript>();
            buttonsList.Add(button);
        }
    }

    private void StartTimer()
    {
        timerEnd = Time.time + timerLenght;
    }

    private void StartNewGame()
    {
        if (gameWon)
        {
            gameLevel++;
            gameLevelWindow.GetComponent<UnityEngine.UI.Text>().text = gameLevel.ToString();
            nbOfButtons += buttonIncrement;
        }
        GenerateButtons();
    }

    private void Win()
    {
        
    }

    public void SubmitPressed()
    {
        if (Time.time >= timerEnd)
        {

        }
    }
}
