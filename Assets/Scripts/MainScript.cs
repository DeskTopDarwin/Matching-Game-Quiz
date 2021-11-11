using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
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
    private bool gameWon = true;
    private int nbOfButtons = 2;
    public List<Button> buttonsList = new List<Button>();
     


    // Start is called before the first frame update

    void Start()
    {
       
    }
    
    private void Awake()
    {
        AddButton();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void AddButton()
    {
        GameObject newButton = Instantiate(buttonPrefabResource, new Vector3(greenZoneContent.transform.position.x, greenZoneContent.transform.position.y, greenZoneContent.transform.position.z),Quaternion.identity);
        newButton.transform.parent = greenZoneContent.transform;
        Button button = GetComponent<Button>();
        buttonsList.Add(button);
    }


    private void CreateGame()
    {
        for (int i = 0; i < nbOfButtons; i++)
        {
            AddButton();
        }
    }

    public void OnClick()
    {
        if (gameWon)
        {
            foreach (Button button in buttonsList)
            {
                Destroy(button);
                buttonsList.Clear();
            }
            nbOfButtons += buttonIncrement;
            gameLevel++;
            CreateGame();

        }
    }


    //private void GenerateButtons()
    //{
    //    for (int i = 0; i < nbOfButtons; i++)
    //    {
    //        GameObject newButton = Instantiate(buttonPrefabResource, greenZoneContent.transform);
    //        newButton.SetActive(true); 
    //        ButtonScript button = newButton.GetComponent<ButtonScript>();
    //        button.gameObject.transform.position = new Vector3(80, 50);
    //        buttonsList.Add(button);
    //    }
    //}
    //
    //private void StartTimer()
    //{
    //    timerEnd = Time.time + timerLenght;
    //}
    //
    //private void StartNewGame()
    //{
    //    if (gameWon)
    //    {
    //        gameLevel++;
    //        nbOfButtons += buttonIncrement;
    //    }
    //    gameLevelWindow.GetComponent<UnityEngine.UI.Text>().text = gameLevel.ToString();
    //    GenerateButtons();
    //}
    //
    //private void Win()
    //{
    //    
    //}
    //
    //public void SubmitPressed()
    //{
    //    if (Time.time >= timerEnd)
    //    {
    //
    //    }
    //}
    //
    //public void OnClick()
    //{
    //
    //}
}
