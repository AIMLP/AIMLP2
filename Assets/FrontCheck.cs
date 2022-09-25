using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCheck : BE2_TargetObjectSpacecraft3D
{

    public static event CheckEvent FrontMonsterOn;
    public static event CheckEvent FrontMonsterOff;
    public static event CheckEvent FrontRoadOn;
    public static event CheckEvent FrontRoadOff;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster")
            FrontMonsterOn();

        if (other.tag == "Road")
            FrontRoadOn();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
