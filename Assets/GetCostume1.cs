using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCostume1 : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (GameManager.CostumeOpen1 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
