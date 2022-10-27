using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE2_Cst_FunctionCall : BE2_InstructionBase, I_BE2_Instruction
{
    //protected override void OnAwake()
    //{
    //    
    //}

    //protected override void OnStart()
    //{
    //    
    //}

    public new bool ExecuteInUpdate => true;

    bool _firstPlay = true;
    float _timer = 0;

    protected override void OnButtonStop()
    {
        _firstPlay = true;
        _timer = 0;
    }

    public override void OnStackActive()
    {
        _firstPlay = true;
        _timer = 0;
    }

    public new void Function()
    {

        //ExecuteSection(0);

        //BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive = true;

        // Debug.Log(BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart);

        if (_firstPlay)
        {
            _firstPlay = false;
        }

        if (_timer < 2)
        {
            _timer += Time.deltaTime / 0.2f;

            if (_timer > 2)
                _timer = 2;

            BE2_Ins_WhenJoystickKeyPressed.instance.FStart();
            BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart = true;
        }
        else
        {
            _timer = 0;
            _firstPlay = true;

        }

    }



    void Update()
    {

        //Debug.Log("Start : " + BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart + "/ Active : " + BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive);
        if (BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart == true && BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive == false)
        {
            BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart = false;
            Debug.Log("FunctionFinish");
            ExecuteNextInstruction();

        }


    }
}
