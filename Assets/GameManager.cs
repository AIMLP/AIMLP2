using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    static public bool CostumeOpen1 = true;
    static public bool CostumeOpen2 = false;
    static public bool CostumeOpen3 = false;
    static public bool CostumeOpen4 = false;


}
