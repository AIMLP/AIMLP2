using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BE2_Cst_BasicAttack : BE2_InstructionBase, I_BE2_Instruction

{

    // ► Refer to the documentation for more on the variables and methods
    // ### Execution Methods ###
    // --- Method used to implement Function Blocks (will only be called by types: simple, condition, loop, trigger)

    public GameObject player;// = GameObject.Find("SwordAndShield");
    public Animator anim;
    private bool animCheck = false;


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


    public new void Function()

    {
     //   player = TargetObject.Transform.GetChild(0).gameObject;
        player = GameObject.Find("SwordAndShield");
        anim = player.GetComponent<Animator>();

        if (_firstPlay)
        {
            _firstPlay = false;
            anim.Play("NormalAttack01_SwordShield");
        }

        if (_timer < 3)
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





        //player = TargetObject.Transform.GetChild(0).gameObject;
        //anim = player.GetComponent<Animator>();

        //anim.Play("NormalAttack01_SwordShield");
        //ExecuteNextInstruction();

    }



   
}
