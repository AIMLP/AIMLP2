using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheck : MonoBehaviour
{
    public string RMonster = "0";
    public string RRoad = "0";

    BE2_VariablesManager _variablesManager;

    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("�����ʿ� ����", RMonster);
        _variablesManager.AddOrUpdateVariable("�����ʿ� ��", RRoad);
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
        RMonster = "1";
        _variablesManager.AddOrUpdateVariable("�����ʿ� ����", RMonster);
    }

    private void RoadOn()
    {
        RRoad = "1";
        _variablesManager.AddOrUpdateVariable("�����ʿ� ��", RRoad);
    }

    private void MonsterOff()
    {
        RMonster = "0";
        _variablesManager.AddOrUpdateVariable("�����ʿ� ����", RMonster);
    }

    private void RoadOff()
    {
        RRoad = "0";
        _variablesManager.AddOrUpdateVariable("�����ʿ� ��", RRoad);
    }

}
