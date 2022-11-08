using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BE2_Cst_Heal : BE2_InstructionBase, I_BE2_Instruction

{
    public Slider HSlider;
    bool _firstPlay = true;

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

    public new void Function()

    {
        CharController HSlider = GameObject.Find("SwordAndShield").GetComponent<CharController>();

        
        if (_firstPlay)
        {
            _firstPlay = false;
            HSlider.hpSlider.value += 5;
            Debug.Log("healing now");
            
        }

        if(_timer < 3)
        {
            _timer += Time.deltaTime / 0.2f;

            if (_timer > 3)
                _timer = 3;
        }
        else
        {
            _timer = 0;
            _firstPlay = true;
            ExecuteNextInstruction();
        }


    }


}
