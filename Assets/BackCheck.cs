using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCheck : MonoBehaviour
{
    public string BMonster = "0";
    public string BRoad = "0";

    BE2_VariablesManager _variablesManager;

    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("�ڿ� ����", BMonster);
        _variablesManager.AddOrUpdateVariable("�ڿ� ��", BRoad);
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
        BMonster = "1";
        _variablesManager.AddOrUpdateVariable("�ڿ� ����", BMonster);
    }

    private void RoadOn()
    {
        BRoad = "1";
        _variablesManager.AddOrUpdateVariable("�ڿ� ��", BRoad);
    }

    private void MonsterOff()
    {
        BMonster = "0";
        _variablesManager.AddOrUpdateVariable("�ڿ� ����", BMonster);
    }

    private void RoadOff()
    {
        BRoad = "0";
        _variablesManager.AddOrUpdateVariable("�ڿ� ��", BRoad);
    }
}
