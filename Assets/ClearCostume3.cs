using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCostume3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
            GameManager.CostumeOpen3 = true;
    }
}
