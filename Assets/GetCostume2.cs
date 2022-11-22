using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCostume2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (GameManager.CostumeOpen2 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
