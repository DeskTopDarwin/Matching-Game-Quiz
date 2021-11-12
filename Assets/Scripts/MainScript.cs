using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class MainScript : MonoBehaviour
{
     
    public int buttonIncrement;
    public float timerLenght = 8;
    public GameObject gameLevelWindow;
    public GameObject submitButton;
    public GameObject buttonPrefabResource;
    public GameObject greenZoneContent;
    public GameObject redZoneContent;


    private float timerEnd;
    private int gameLevel = 1;
    private bool gameWon = true;
    private int nbOfButtons = 2;
     


    // Start is called before the first frame update

    void Start()
    {
       
    }
    
    private void Awake()
    {
        CreateGame();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void DestroyChildren()
    {
        int childrenGreen = greenZoneContent.transform.childCount;
        if (childrenGreen > 0)
        {
            for (int i = 0; i < childrenGreen; ++i)
                Destroy(greenZoneContent.transform.GetChild(i).gameObject);
        }


        int childrenRed = greenZoneContent.transform.childCount;
        if (childrenRed > 0)
        {
            for (int i = 0; i < childrenRed; ++i)
                Destroy(greenZoneContent.transform.GetChild(i).gameObject);
        }
        
    }

    //private void addListenerToButton()
    //{
    //    int childrenGreen = greenZoneContent.transform.childCount;
    //    if (childrenGreen > 0)
    //    {
    //        for (int i = 0; i < childrenGreen; ++i)
    //            greenZoneContent.GetComponent<Button>().onClick.AddListener(ChangeParent);
    //    }
    //
    //    int childrenRed = greenZoneContent.transform.childCount;
    //    if (childrenRed > 0)
    //    {
    //        for (int i = 0; i < childrenRed; ++i)
    //            greenZoneContent.GetComponent<Button>().onClick.AddListener(ChangeParent);
    //    }
    //}

    
    private void AddButton()
    {
        GameObject newButton = Instantiate(buttonPrefabResource, new Vector3(greenZoneContent.transform.position.x, greenZoneContent.transform.position.y, greenZoneContent.transform.position.z),Quaternion.identity);
        newButton.transform.parent = greenZoneContent.transform;
        //GetComponent<Button>().onClick.AddListener(ChangeParent);
    }
    public void ChangeParent()
    {

    }

    private void CreateGame()
    {
        if (gameLevel >= 1)
        {
            DestroyChildren();
        }

        for (int i = 0; i < nbOfButtons; i++)
        {
            AddButton();
            //addListenerToButton();
        }
        gameLevelWindow.GetComponent<UnityEngine.UI.Text>().text = gameLevel.ToString();
        timerEnd = Time.time + timerLenght;
    }

    public void OnClick()
    {
        if (gameWon && Time.time >= timerEnd)
        {
            nbOfButtons += buttonIncrement;
            CreateGame();
            gameLevel++;
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
