using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE2_Ins_MoveForward : BE2_InstructionBase, I_BE2_Instruction
{
    //protected override void OnAwake()
    //{
    //
    //}

    //protected override void OnStart()
    //{
    //    
    //}

    I_BE2_BlockSectionHeaderInput _input0;
    float _value;

    //protected override void OnPlay()
    //{
    //    
    //}

    bool _firstPlay = true;

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

    float _timer = 0;
    Vector3 _initialPosition;

    public new void Function()
    {
        _input0 = Section0Inputs[0];
        _value = _input0.FloatValue;
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
            ExecuteNextInstruction();
        }
    
        //TargetObject.Transform.position += TargetObject.Transform.forward * _value;
        //ExecuteNextInstruction();
    }
}
