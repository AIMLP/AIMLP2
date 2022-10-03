using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClearCheck : MonoBehaviour
{
    public string StageClear = "0";

    BE2_VariablesManager _variablesManager;

    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("µµÂø", StageClear);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "StageClear")
            StageClearOn();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "StageClear")
            StageClearOff();
    }

    private void StageClearOn()
    {
        StageClear = "1";
        _variablesManager.AddOrUpdateVariable("µµÂø", StageClear);
    }

    private void StageClearOff()
    {
        StageClear = "0";
        _variablesManager.AddOrUpdateVariable("µµÂø", StageClear);
    }


}
