using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EnumColor
{
    RED,
    GREEN
};

public class ButtonScript : MonoBehaviour
{
    public float timerLenght = 8;
    public Text buttonText;

    private float timerEnd;
    public EnumColor color;

    // Start is called before the first frame update


    void Start() 
    {
        int randomNumber = Random.Range(0, 100);
        buttonText.text = randomNumber.ToString();

        int colorValue = randomNumber % 2;

        if (colorValue > 0)
        {
            color = EnumColor.GREEN;
        }
        else
        {
            color = EnumColor.RED;
        }

        switch (color)
        {
            case EnumColor.RED:
                GetComponent<Image>().color = Color.red;
                break;
            case EnumColor.GREEN:
                GetComponent<Image>().color = Color.green;
                break;
            default:
                break;
        }


        //set timer;
        timerEnd = Time.time + timerLenght;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timerEnd)
        {
            timerEnd = float.MaxValue;
            //GetComponent<Image>().color = ;
            gameObject.GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, Color.white, timerLenght);
        }

    }
}
