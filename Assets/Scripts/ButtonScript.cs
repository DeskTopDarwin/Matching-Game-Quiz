using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public UnityEngine.UI.Text buttonText;
    // Start is called before the first frame update
    void Start() 
    {
        int randomNumber = Random.Range(0, 100);
        buttonText.text = randomNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
