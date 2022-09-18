using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE2_Ins_TurnDirection : BE2_InstructionBase, I_BE2_Instruction
{
    //protected override void OnAwake()
    //{
    //
    //}

    //protected override void OnStart()
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
    Quaternion _initialPosition;

    I_BE2_BlockSectionHeaderInput _input0;
    string _value;
  //  Vector3 _axis = Vector3.up;

    public new void Function()
    {
        _input0 = Section0Inputs[0];
        _value = _input0.StringValue;
        if (_value == "왼쪽")
        {
            if (_firstPlay)
            {
                _initialPosition = TargetObject.Transform.rotation;
                _firstPlay = false;
            }

            if (_timer < 2)
            {
                // adjust the divisor value to change the rotation velocity
                _timer += Time.deltaTime / 0.2f;

                if (_timer > 2)
                    _timer = 2;

                var rotation = _initialPosition;
                rotation *= Quaternion.Euler(0, -90, 0);

                TargetObject.Transform.rotation = Quaternion.Lerp(_initialPosition, rotation, _timer);
            }
            else
            {
                _timer = 0;
                _firstPlay = true;
                ExecuteNextInstruction();
            }
        
        //TargetObject.Transform.Rotate(_axis, -90);
        }
        else if (_value == "오른쪽")
        {
            if (_firstPlay)
            {
                _initialPosition = TargetObject.Transform.rotation;
                _firstPlay = false;
            }

            if (_timer < 2)
            {
                // adjust the divisor value to change the rotation velocity
                _timer += Time.deltaTime / 0.2f;

                if (_timer > 2)
                    _timer = 2;

                var rotation = _initialPosition;
                rotation *= Quaternion.Euler(0, 90, 0);

                TargetObject.Transform.rotation = Quaternion.Lerp(_initialPosition, rotation, _timer);
            }
            else
            {
                _timer = 0;
                _firstPlay = true;
                ExecuteNextInstruction();
            }
            //TargetObject.Transform.Rotate(_axis, 90);
        }

        //ExecuteNextInstruction();
    }
}
