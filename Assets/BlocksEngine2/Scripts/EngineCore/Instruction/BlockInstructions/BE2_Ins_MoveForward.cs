using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE2_Ins_MoveForward : BE2_InstructionBase, I_BE2_Instruction
{

    BE2_VariablesManager _variablesManager;
    protected override void OnStart()
    {
        _variablesManager = BE2_VariablesManager.instance;
    }




    I_BE2_BlockSectionHeaderInput _input0;
    I_BE2_BlockSectionHeaderInput _input1;
    float _value;
    string _value2;

    //protected override void OnPlay()
    //{
    //    
    //}

    bool _firstPlay = true;
    float _timer = 0;

    // needed for functions that use lerp 
    public new bool ExecuteInUpdate => true;

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

    Vector3 _initialPosition;
    string front = "0";
    string back = "0";
    public new void Function()
    {
        _input0 = Section0Inputs[0];
        _input1 = Section0Inputs[1];
        _value = _input0.FloatValue;
        _value2 = _input1.StringValue;
        
        if (_variablesManager.GetVariableStringValue("앞에 길") == "1")
            front = _variablesManager.GetVariableStringValue("앞에 길") ;

        if (_variablesManager.GetVariableStringValue("뒤에 길") == "1")
            back = _variablesManager.GetVariableStringValue("뒤에 길");


        if (front == "1")
        {
            if (_value2 == "앞")
            {
                if (_firstPlay)
                {
                    _initialPosition = TargetObject.Transform.position;
                    _firstPlay = false;
                }

                if (_timer < 2)
                {
                    _timer += Time.deltaTime / 0.2f;

                    if (_timer > 2)
                        _timer = 2;

                    var position = _initialPosition;
                    position += TargetObject.Transform.forward * _value;

                    TargetObject.Transform.position = Vector3.Lerp(_initialPosition, position, _timer);
                }
                else
                {
                    _timer = 0;
                    _firstPlay = true;
                    front = "0";
                    ExecuteNextInstruction();
                }
            }
        }

        if (back == "1")
        {
            if (_value2 == "뒤")
            {
                if (_firstPlay)
                {
                    _initialPosition = TargetObject.Transform.position;
                    _firstPlay = false;
                }

                if (_timer < 2)
                {
                    _timer += Time.deltaTime / 0.2f;

                    if (_timer > 2)
                        _timer = 2;

                    var position = _initialPosition;
                    position -= TargetObject.Transform.forward * _value;

                    TargetObject.Transform.position = Vector3.Lerp(_initialPosition, position, _timer);
                }
                else
                {
                    _timer = 0;
                    _firstPlay = true;
                    back = "0";
                    ExecuteNextInstruction();
                }
            }
        }

        
        //TargetObject.Transform.position += TargetObject.Transform.forward * _value;
        //ExecuteNextInstruction();
    }
}
