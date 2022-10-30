using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCheck : BE2_TargetObjectSpacecraft3D
{

    public string FMonster = "0";
    public string FRoad = "0";

    BE2_VariablesManager _variablesManager;

    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("�տ� ����", FMonster);
        _variablesManager.AddOrUpdateVariable("�տ� ��", FRoad);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Monster")
            MonsterOff();


        if (other.tag != "Road")
            RoadOff();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Monster")
            MonsterOn();


        if (other.tag == "Road")
            RoadOn();

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Monster")
            MonsterOff();
        
        if (other.tag == "Road")
            RoadOff();
    }

    private void MonsterOn()
    {
        FMonster = "1";
        _variablesManager.AddOrUpdateVariable("�տ� ����", FMonster);
        Debug.Log("����ON");
    }

    private void RoadOn()
    {
        FRoad = "1";
        _variablesManager.AddOrUpdateVariable("�տ� ��", FRoad);
    }

    private void MonsterOff()
    {
        FMonster = "0";
        _variablesManager.AddOrUpdateVariable("�տ� ����", FMonster);
        Debug.Log("����OFF");
    }

    private void RoadOff()
    {
        FRoad = "0";
        _variablesManager.AddOrUpdateVariable("�տ� ��", FRoad);
    }



}
