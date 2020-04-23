using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleAppManager : MonoBehaviour
{
    public Text HelloText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnHelloButton()
    {
        HelloText.GetComponent<Text>().text = "Hello Tongchun!";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
