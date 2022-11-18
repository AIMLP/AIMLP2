using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public GameObject character;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickRestart()
    {
        character.GetComponent<CharController>().hpSlider.value = character.GetComponent<CharController>().hpSlider.maxValue;

    }
}
