using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCostume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
            GameManager.CostumeOpen2 = true;
    }
}
