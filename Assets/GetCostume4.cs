using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCostume4 : MonoBehaviour
{
    void Update()
    {
        if (GameManager.CostumeOpen4 == true)
        {
            gameObject.SetActive(false);
        }
    }
}
