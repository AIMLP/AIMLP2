using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCostume3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (GameManager.CostumeOpen3 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
