using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCheck : MonoBehaviour
{
    public string LMonster = "0";
    public string LRoad = "0";

    BE2_VariablesManager _variablesManager;

    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("���ʿ� ����", LMonster);
        _variablesManager.AddOrUpdateVariable("���ʿ� ��", LRoad);
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
        LMonster = "1";
        _variablesManager.AddOrUpdateVariable("���ʿ� ����", LMonster);
    }

    private void RoadOn()
    {
        LRoad = "1";
        _variablesManager.AddOrUpdateVariable("���ʿ� ��", LRoad);
    }

    private void MonsterOff()
    {
        LMonster = "0";
        _variablesManager.AddOrUpdateVariable("���ʿ� ����", LMonster);
    }

    private void RoadOff()
    {
        LRoad = "0";
        _variablesManager.AddOrUpdateVariable("���ʿ� ��", LRoad);
    }

}
