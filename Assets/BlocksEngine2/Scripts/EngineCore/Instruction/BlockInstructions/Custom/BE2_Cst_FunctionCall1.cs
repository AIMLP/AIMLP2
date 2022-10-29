using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BE2_Cst_FunctionCall1 : BE2_InstructionBase, I_BE2_Instruction

{
    //protected override void OnAwake()
    //{
    //    
    //}

    //protected override void OnStart()
    //{
    //    
    //}
    BE2_VariablesManager _variablesManager;
    void Start()
    {
        _variablesManager = BE2_VariablesManager.instance;
        _variablesManager.AddOrUpdateVariable("�Ű�����1", "0");
    }

    public new bool ExecuteInUpdate => true;

    bool _firstPlay = true;
    float _timer = 0;
    bool IsFunctionCall = false;

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
            IsFunctionCall = true;
        }

        if (_timer < 2)
        {
            _timer += Time.deltaTime / 0.2f;

            if (_timer > 2)
                _timer = 2;

            BE2_Ins_WhenJoystickKeyPressed.instance.FStart();
            BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart = true;
            _variablesManager.AddOrUpdateVariable("�Ű�����1", Section0Inputs[0].StringValue);
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
        if (IsFunctionCall == true && BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart == true && BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionActive == false)
        {
            BE2_Ins_WhenJoystickKeyPressed.instance.IsFunctionStart = false;
            Debug.Log("FunctionFinish");
            IsFunctionCall = false;
            ExecuteNextInstruction();

        }


    }

}
